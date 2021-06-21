package receiver;

import java.io.*;

public class ConsoleReader implements IDataReader {
	
	private BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

	@Override
	public String getNext() {
		try {
			return reader.readLine();
		} catch (IOException e) {return null;}
	}
}
