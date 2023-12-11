class Main {
	public static void main(String[] arg) {
		Shop shop = new Shop("ЛУчик");
		shop.addItem(new Item("Футболка", "Заря", Item.Type.Clothes), 35);
		shop.addItem(new Item("Рубашка", "Заря", Item.Type.Clothes), 10);
		shop.addItem(new Item("Майка", "Заря", Item.Type.Clothes), 15);
		shop.addItem(new Item("Шорты", "Заря", Item.Type.Clothes), 25);
		shop.addItem(new Item("Кофта", "Заря", Item.Type.Clothes), 5);
		
		System.out.println("Магазин " + shop.getName() + " имеет в наличии " + shop.getCountTypeItems() + " видов товара:");
		for(int i = 0; i < shop.getCountTypeItems(); i++) {
			Item item = shop.getItem(i);
			System.out.println((i + 1) + ") " + item.getName() + " " + shop.getCountItem(item)+"шт;");
		}
	}
}