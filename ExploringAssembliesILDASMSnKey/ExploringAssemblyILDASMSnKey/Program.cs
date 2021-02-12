using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringAssemblyILDASMSnKey
{
    /*
     * Every project created in C# is a private assembly
     * Public assembly : .net assembly used as namespace 
     * Satellite assembly - Localization and globalization 
     * .resx is used to store different language mapping 
     * 
     * 
     * Private assembly can be converted into public assembly
     * 
     * 1. given a public key token
     * Generate a public key token using sn(Strong name)
     * sn -k mykey.snk
     * 
     * 2. Sign the assembly by project properties and signing 
     * 
     * 3. Install the assembly in GAC
     *      gacutil -i projectname
     *
     */
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
        }
    }
}
