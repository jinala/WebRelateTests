import sys
import os
import numpy as np
import matplotlib.pyplot as pl
import numpy as np
import matplotlib 
matplotlib.rc('xtick', labelsize=20) 
matplotlib.rc('ytick', labelsize=20) 
matplotlib.rcParams.update({'font.size': 20})
            
            


def parseExtractionOutputs(ranking_mode):
    dir = extractionsdir + "/Ranking" + str(ranking_mode)
    outputs = {}
    for d in os.listdir(dir):
        for i in os.listdir(dir + "/" + d):
            file = open(dir + "/" + d + "/" + i)
            lines = [l.strip() for l in file.readlines()]
            testname = lines[0]
            status = lines[1]
            if status  == "FAILED":
                continue
            category = (int(testname[0]))
            nexamples = (int(lines[2]))
            totaltime = (float(lines[4])/1000.0)
            lasttime = (float(lines[3])/1000.0)
            totalsearchtime = (float(lines[6])/1000.0)
            lastsearchtime = (float(lines[5])/1000.0)
            totalbingtime = (float(lines[8])/1000.0)
            lastbingtime = (float(lines[7])/1000.0)
            lasttreetime = (float(lines[9])/1000.0)
            totaltreetime = (float(lines[10])/1000.0)
            lastintersecttime = (float(lines[11])/1000.0)
            totalintersecttime = (float(lines[12])/1000.0)
            lastmintime = (float(lines[13])/1000.0)
            totalmintime = (float(lines[14])/1000.0)
            lastnumchecks = (int(lines[15]))
            totalnumchecks = (int(lines[16]))
            file.close()
            
            if testname in outputs:
                outputs[testname].append((nexamples, category, lasttreetime, lastintersecttime, lastmintime))
            else:
                outputs[testname] = [(nexamples, category, lasttreetime, lastintersecttime, lastmintime)]
                
    categories = []
    median_nexamples = []
    median_tree_times = []
    median_intersect_times = []
    median_min_times = []
    for t in outputs:
        median_nexamples.append(np.median([d[0] for d in outputs[t]]))
        categories.append(outputs[t][0][1])
        median_tree_times.append(np.median([d[2] for d in outputs[t]]))
        median_intersect_times.append(np.median([d[3] for d in outputs[t]]))
        median_min_times.append(np.median([d[4] for d in outputs[t]]))
        
            
    return (categories, median_nexamples, median_tree_times, median_intersect_times, median_min_times)


def plotExtractionTimeGraph(data):
    if 1 in data:
        categories, examples, tree_times, intersect_times, min_times = data[1]
        
        total_times = []
        for i in range(len(tree_times)):
            sum = tree_times[i] + min_times[i] + intersect_times[i]
            total_times.append(sum)
    
        categories, total_times, tree_times, intersect_times, min_times = (list(t) for t in zip(*sorted(zip(categories, total_times, tree_times, intersect_times, min_times))))
        pl.figure(figsize=(20,5))

        ind = np.arange(len(tree_times))
        p1 = pl.bar(ind, tree_times, 0.5, color='g', hatch='///')
        p2 = pl.bar(ind, intersect_times, 0.5, color='y', bottom=tree_times, hatch = '|||')
        p3 = pl.bar(ind, min_times, 0.5, color='r', bottom=[i+j for i,j in zip(tree_times, intersect_times)], hatch = '\\\\\\')
        pl.legend((p1[0], p2[0], p3[0]), ("T_pred", "T_intersect", "T_search"), loc='upper left',fontsize=15)
        pl.ylabel("Time (s)", fontsize =20)
        pl.xlabel("Benchmarks", fontsize=20)
        pl.title("Run times for data extraction learning")
        pl.savefig(graphsdir + "extraction_time.pdf",bbox_inches='tight')
        pl.close()
    
def plotExtractionExamplesGraph(data):
    colors = {1: 'g', 0: 'r'}
    lineshapes = {1: 'solid', 0: 'dashed'}
    labels = {1: 'Output-constrained ranking', 0: 'Basic ranking'}
    
    for ranking in [1, 0]:
        if ranking in data:
            categories, examples, tree_times, intersect_times, min_times = data[ranking]
            # sorted them first based on category and then based on nexmples
            categories, examples = (list(t) for t in zip(*sorted(zip(categories, examples))))
                
            ind1 = np.nonzero(np.array(categories) == 1)
            ind2 = np.nonzero(np.array(categories) == 2)
            ind3 = np.nonzero(np.array(categories) == 3)
            
            p1= pl.plot(ind1[0], np.array(examples)[ind1], linewidth=3, color=colors[ranking], ls = lineshapes[ranking], label=labels[ranking])
            p2= pl.plot(ind2[0], np.array(examples)[ind2], linewidth=3, color=colors[ranking], ls = lineshapes[ranking])
            p3= pl.plot(ind3[0], np.array(examples)[ind3], linewidth=3, color=colors[ranking], ls = lineshapes[ranking])
    
    pl.xlabel("Benchmarks", fontsize = 20)
    pl.yticks(range(0,10))
    pl.ylabel("# examples", fontsize = 20)  
    pl.title("# examples required for Data Extraction learning")
    pl.legend(loc='upper left', fontsize=15)
    pl.savefig(graphsdir + "extraction_ex.pdf",bbox_inches='tight')
    pl.close()
    

def plotUrlTimeGraph(data):
    colors = {1:'g', 2:'k', 3:'b', 4:'r'}
    lineshapes = {1:'solid', 2:'dotted', 3:'dashdot', 4:'dashed'}
    labels = {1: 'L1 to L4', 2: 'L2 to L4', 3: 'L3 to L4', 4: 'Only L4'}
    for layer in [1, 2, 3, 4]:
        if layer in data and 1 in data[layer]:
            categories, examples, times = data[layer][1]
            # sorted them first based on category and then based on time
            categories, times = (list(t) for t in zip(*sorted(zip(categories, times))))
            
            ind1 = np.nonzero(np.array(categories) == 1)
            ind2 = np.nonzero(np.array(categories) == 2)
            ind3 = np.nonzero(np.array(categories) == 3)
            
            p1= pl.plot(ind1[0], np.array(times)[ind1], linewidth=3, color=colors[layer], ls = lineshapes[layer], label=labels[layer])
            p2= pl.plot(ind2[0] + (31 - ind1[0][-1]), np.array(times)[ind2], linewidth=3, color=colors[layer], ls = lineshapes[layer])
            p3= pl.plot(ind3[0] + (50 - ind2[0][-1]), np.array(times)[ind3], linewidth=3, color=colors[layer], ls = lineshapes[layer])
    
    pl.ylabel("Time (s)", fontsize=20)
    pl.xlabel("Benchmarks", fontsize=20)
    pl.ylim([0,10])
    pl.title("Run times for URL learning")
    pl.legend(loc='upper left', fontsize=15)
    pl.savefig(graphsdir + "url_time.pdf",bbox_inches='tight')
    pl.close()


def plotUrlExamplesGraph(data):
    colors = {1:'g', 0:'r'}
    lineshapes = {1:'solid', 0:'dashed'}
    labels = {1: 'Output-constrained ranking', 0: 'Basic ranking'}
    
    for ranking in [1, 0]:
        if 1 in data and ranking in data[1]:
            categories, examples, times = data[1][ranking]
            # sorted them first based on category and then based on nexmples
            categories, examples = (list(t) for t in zip(*sorted(zip(categories, examples))))
            
            ind1 = np.nonzero(np.array(categories) == 1)
            ind2 = np.nonzero(np.array(categories) == 2)
            ind3 = np.nonzero(np.array(categories) == 3)
            
            p1= pl.plot(ind1[0], np.array(examples)[ind1], linewidth=3, color=colors[ranking], ls = lineshapes[ranking], label=labels[ranking])
            p2= pl.plot(ind2[0] + (31 - ind1[0][-1]), np.array(examples)[ind2], linewidth=3, color=colors[ranking], ls = lineshapes[ranking])
            p3= pl.plot(ind3[0] + (50 - ind2[0][-1]), np.array(examples)[ind3], linewidth=3, color=colors[ranking], ls = lineshapes[ranking])
    
    pl.xlabel("Benchmarks", fontsize = 20)
    pl.yticks(range(0,10))
    pl.ylabel("# examples", fontsize = 20)  
    pl.title("# examples required for URL learning")
    pl.legend(loc='upper left', fontsize=15)
    pl.savefig(graphsdir + "url_ex.pdf",bbox_inches='tight')
    pl.close()
    

def getUrlCategory(testname):
    if (int(testname[0]) == 3):
        return 1
    else:
        if (not testname[1].isdigit()):
            return (int(testname[0]))
        if (int(testname[1]) == 4):
            return 3
        else:
            return (int(testname[1]))

def parseUrlOutputs(layer_mode, ranking_mode):
    dir = urlsdir + "/Layer" + str(layer_mode) + "/Ranking" + str(ranking_mode)
    outputs = {}
    for d in os.listdir(dir):
        for i in os.listdir(dir + "/" + d):
            file = open(dir + "/" + d + "/" + i)
            lines = [l.strip() for l in file.readlines()]
            testname = lines[0]
            status = lines[1]
            if status  == "FAILED":
                continue
            category = getUrlCategory(testname)
            nexamples = (int(lines[2]))
            totaltime = (float(lines[4])/1000.0)
            lasttime = (float(lines[3])/1000.0)
            totalsearchtime = (float(lines[6])/1000.0)
            lastsearchtime = (float(lines[5])/1000.0)
            totalbingtime = (float(lines[8])/1000.0)
            lastbingtime = (float(lines[7])/1000.0)
            file.close()
            
            if testname in outputs:
                outputs[testname].append((nexamples, category, lastsearchtime))
            else:
                outputs[testname] = [(nexamples, category, lastsearchtime)]
                
    categories = []
    median_nexamples = []
    median_times = []
    for t in outputs:
        median_nexamples.append(np.median([d[0] for d in outputs[t]]))
        categories.append(outputs[t][0][1])
        median_times.append(np.median([d[2] for d in outputs[t]]))
            
    return (categories, median_nexamples, median_times)

def processUrls():
    data = {} #map from layer_mode to ranking_mode to array of tuples (benchmark name,category, median #examples, median time)
    data[1] = {}
    data[2] = {}
    data[3] = {}
    data[4] = {}
    data[1][1] = parseUrlOutputs(1, 1) # layer_mode 1, ranking_mode 1
    data[1][0] = parseUrlOutputs(1, 0) # layer_mode 1, ranking_mode 0
    data[2][1] = parseUrlOutputs(2, 1) # layer_mode 2, ranking_mode 1
    data[3][1] = parseUrlOutputs(3, 1) # layer_mode 3, ranking_mode 1
    data[4][1] = parseUrlOutputs(4, 1) # layer_mode 4, ranking_mode 1
    plotUrlTimeGraph(data)
    plotUrlExamplesGraph(data)

    
def processExtractions():
    data = {} # map from ranking_mode to array of tuples (benchmark name, category, median # examples, median times)
    data[1] = parseExtractionOutputs(1) # ranking_mode 1
    data[0] = parseExtractionOutputs(0) # ranking_mode 0
    plotExtractionTimeGraph(data)
    plotExtractionExamplesGraph(data)
    
    
outputdir = sys.argv[1]
graphsdir = outputdir + "/graphs/"
if not os.path.exists(graphsdir):
    os.makedirs(graphsdir)

urlsdir = outputdir + "/urls/"
extractionsdir = outputdir + "/extractions/"



processUrls()
processExtractions()
