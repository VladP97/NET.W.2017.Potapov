using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Interfaces;

namespace BLL.Interface.Entities
{
    public class StandartBonusAlgorithm : IBonusAlgorithm
    {
        private static StandartBonusAlgorithm instance;

        private static object syncRoot = new Object();

        protected StandartBonusAlgorithm()
        {
            
        }

        public int GetBonus(decimal sum, int bonus)
        {
            return (int)(sum / bonus * 10);
        }

        public static StandartBonusAlgorithm GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new StandartBonusAlgorithm();
                }
            }
            return instance;
        }
    }
}
