import java.io.BufferedWriter;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;

public class Main {

	public static void main(String[] args) throws IOException {
		Path p = Paths.get("file1.txt");
		write(p, "Петр;Петров;Петрович;170;80;1;1;1970;88005553535;Россия;Московская область;Московский район;Москва;Большая садовая;302-бис;50;111;2222000022220000;123456789");
		write(p, "Михаил;Михайлов;Михайлович;170;80;1;1;1970;88005553535;Россия;Владимирская область;Муромский район;Муром;Большая садовая;302-бис;50;111;2222000022220000;123456789");
		write(p, "Василий;Васильев;Васильевич;170;80;1;1;1970;88005553535;Россия;Владимирская область;Муромский район;Муром;Большая садовая;302-бис;50;111;2222000022220000;123456789");
		write(p, "Иван;Иванов;Иванович;170;80;1;1;1970;88005553535;Россия;Владимирская область;Муромский район;Муром;Большая садовая;302-бис;50;111;2222000022220000;123456789");
		Item[] arr = read(p);
		for(Item i : arr) {
			if(i.getAddress() != null && i.getAddress().getCity().equals("Муром")) {
				System.out.println(i.getName() + " " + i.getSurname());
			}
		}
	}
	static Item[] read(Path path) throws IOException {
		String[] arr1 = Files.readString(path).split("\n");
		Item[] arr2 = new Item[arr1.length];
		for(int i = 0; i < arr1.length; i++) {
			arr2[i] = Item.parse(arr1[i]);
		}
		return arr2;
	}
	static void write(Path path, String str) throws IOException {
		if(!Files.exists(path)) {
			Files.createFile(path);
		}
		else
		{
			str = "\n" + str;
		}
		BufferedWriter writer = Files.newBufferedWriter(path, StandardCharsets.UTF_8, StandardOpenOption.APPEND);
		writer.write(str);
		writer.close();
	}
}
