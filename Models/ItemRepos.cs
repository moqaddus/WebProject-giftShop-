namespace WebWebWeb.Models
{
    public class ItemRepos
    {
        public void addProduct(InventoryItem item)
        {
            GiftShopOneContext cx=new GiftShopOneContext();
            cx.InventoryItems.Add(item);
            cx.SaveChanges();
        }

        public bool removeProduct(InventoryItem t)
        {
            GiftShopOneContext cx = new GiftShopOneContext();
            var items=cx.InventoryItems.ToList();
            foreach(InventoryItem item in items)
            {
                if(item.ItemName == t.ItemName && item.Category==t.Category)
                {
                    cx.InventoryItems.Remove(item);
                    cx.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool isItem(InventoryItem t)
        {
            GiftShopOneContext cx = new GiftShopOneContext();
            var items = cx.InventoryItems.ToList();
            foreach (InventoryItem item in items)
            {
                if (item.ItemName == t.ItemName && item.Category == t.Category)
                {
                    return true;
                }
            }
            return false;

        }

        public InventoryItem? getItem(int id)
        {
            GiftShopOneContext cx = new GiftShopOneContext();
            var items = cx.InventoryItems.ToList();
            foreach (InventoryItem item in items)
            {
                if (item.ItemId == id )
                {
                    return item;
                }

            }
            return null;
            
        }
        public List<InventoryItem> findBirthdayItems()
        {
            List<InventoryItem> itemList = new List<InventoryItem>();
            GiftShopOneContext cx = new GiftShopOneContext();
            var items = cx.InventoryItems.ToList();
            foreach (InventoryItem item in items)
            {
                if (item.Category == "birthday")
                {
                    itemList.Add(item);
                }
            }
            return itemList;

        }


        public List<InventoryItem> findAnniversaryItems()
        {
            List<InventoryItem> itemList = new List<InventoryItem>();
            GiftShopOneContext cx = new GiftShopOneContext();
            var items = cx.InventoryItems.ToList();
            foreach (InventoryItem item in items)
            {
                if (item.Category == "anniversary")
                {
                    itemList.Add(item);
                }
            }
            return itemList;

        }

        public List<InventoryItem> findGiftBasketItems()
        {
            List<InventoryItem> itemList = new List<InventoryItem>();
            GiftShopOneContext cx = new GiftShopOneContext();
            var items = cx.InventoryItems.ToList();
            foreach (InventoryItem item in items)
            {
                if (item.Category == "basket")
                {
                    itemList.Add(item);
                }
            }
            return itemList;

        }


    }
}
