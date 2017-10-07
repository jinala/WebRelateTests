// ***********************************************************************
// Copyright (c) 2015 Charlie Poole, Rob Prouse
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using NUnitLite;
using System;

namespace NUnitLite.Tests
{
    public class Program
    {
        /// <summary>
        /// The main program executes the tests. Output may be routed to
        /// various locations, depending on the arguments passed.
        /// </summary>
        /// <remarks>Run with --help for a full list of arguments supported</remarks>
        /// <param name="args"></param>
        public static int Main(string[] args)
        {
            //Console.WriteLine(args);
            if (args.Length >= 2)
            {
                int num_runs = Convert.ToInt32(args[args.Length - 2]);
                int ranking_mode = Convert.ToInt32(args[args.Length - 1]);
                //Console.WriteLine("Running each test with " + num_runs + " runs using ranking mode " + ranking_mode);
                WebExtractionPBE.WebRelateTestUtil.NUM_RUNS = num_runs;
                WebExtractionPBE.WebRelateTestUtil.RANKING_MODE = ranking_mode;
                DataStudio.PublicAPI.rankingMode = ranking_mode;
                string[] newargs = new string[args.Length - 2];
                Array.Copy(args, 0, newargs, 0, args.Length - 2);
                return new AutoRun().Execute(newargs);
            }
            else
            {
                return new AutoRun().Execute(args);
            }
        }
    }
}