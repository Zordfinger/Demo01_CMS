namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined order
            return new Order(orderId);
        }

        /// <summary>
        /// Saves the specified order.
        /// </summary>
        public bool Save(Order order)
        {
            // Code that saves the defined order
            return true;
        }
    }
}
