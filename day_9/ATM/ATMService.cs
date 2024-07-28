
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ATM
{
    public class ATMService
    {
        private Dictionary<int, int> cash = [];

        public void Deposit(int cashType, int amount)
        {
            if (cash.ContainsKey(cashType))
            {
                cash[cashType] += amount;
            }
            else
            {
                cash.Add(cashType, amount);
            }
        }

        public IReadOnlyDictionary<int, int> GetExistingCash()
        {
            return new ReadOnlyDictionary<int, int>(cash);
        }

        public List<int> Withdraw(int amount)
        {
            List<int> list = [];
            if (amount % 50 != 0)
            {
                throw new InvalidOperationException("Amount should not be less then 50");
            }

            var orderedKeshType = cash.Keys.OrderByDescending(x => x);

            foreach (var cashType in orderedKeshType)
            {
                while (amount >= cashType && cash[cashType] > 0)
                {
                    cash[cashType] -= 1;
                    amount -= cashType;
                    list.Add(cashType);
                }
            }

            if (amount != 0)
            {
                foreach (var item in list.GroupBy(s => s))
                {
                    Deposit(item.Key, item.Count());
                }

                throw new InvalidOperationException("ATM does not have nassesary cash type");
            }
            return list;
        }
    }
}
