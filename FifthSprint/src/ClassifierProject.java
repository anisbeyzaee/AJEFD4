import java.io.File;
import java.io.IOException;

public class ClassifierProject {
	
	public ClassifierProject() throws IOException{
		//File file = new File("C://Users//Meg//Downloads//april24networkfile.xml");
		File file = new File("C://Users//Meg//Downloads//networkInfoFile.xml");
		//String imagePathName = "C:\\Users\\Meg\\Documents\\NoFireImages\\forest-satellite.jpg";
		//String resizedImagePathName = "C:\\Users\\Meg\\Documents\\FireResized\\forest-satellite.jpg";
		
		String[] imagePathName = {"C:\\Users\\Meg\\Documents\\FireImages\\fire1.png", "C:\\Users\\Meg\\Documents\\FireImages\\fires_satellite.jpg",
				"C:\\Users\\Meg\\Documents\\FireImages\\black-forest-fire.jpg", "C:\\Users\\Meg\\Documents\\FireImages\\gettyimages-453244092-612x612.jpg", 
				"C:\\Users\\Meg\\Documents\\FireImages\\fire3.jpg", "C:\\Users\\Meg\\Documents\\FireImages\\fire2.jpg", "C:\\Users\\Meg\\Documents\\FireImages\\california-fire-space-station-03-ht-jc-171206_4x3_992.jpg", 
				"C:\\Users\\Meg\\Documents\\FireImages\\amazon-basin-forest-fires-satellite-nasa--science-source.jpg", "C:\\Users\\Meg\\Documents\\FireImages\\gettyimages-472428640-612x612.jpg",
				"C:\\Users\\Meg\\Documents\\NoFireImages\\forest-satellite.jpg",
				"C:\\Users\\Meg\\Documents\\NoFireImages\\post-19299-1226593197.jpg", "C:\\Users\\Meg\\Documents\\NoFireImages\\Cambodia-Forest-Image-2-1024x1024.jpg", 
				"C:\\Users\\Meg\\Documents\\NoFireImages\\santuk_etm_2000366.jpg", "C:\\Users\\Meg\\Documents\\NoFireImages\\300px-Forest_example.png"};
		
		String[] resizedImagePathName = {"C:\\Users\\Meg\\Documents\\FireResized\\fire1.png", "C:\\Users\\Meg\\Documents\\FireResized\\fires_satellite.jpg",
				"C:\\Users\\Meg\\Documents\\FireResized\\black-forest-fire.jpg", "C:\\Users\\Meg\\Documents\\FireResized\\gettyimages-453244092-612x612.jpg", 
				"C:\\Users\\Meg\\Documents\\FireResized\\fire3.jpg", "C:\\Users\\Meg\\Documents\\FireResized\\fire2.jpg", "C:\\Users\\Meg\\Documents\\FireResized\\california-fire-space-station-03-ht-jc-171206_4x3_992.jpg", 
				"C:\\Users\\Meg\\Documents\\FireResized\\amazon-basin-forest-fires-satellite-nasa--science-source.jpg", "C:\\Users\\Meg\\Documents\\FireResized\\gettyimages-472428640-612x612.jpg", "C:\\Users\\Meg\\Documents\\NoFireResized\\forest-satellite.jpg", 
				"C:\\Users\\Meg\\Documents\\NoFireResized\\post-19299-1226593197.jpg", "C:\\Users\\Meg\\Documents\\NoFireResized\\Cambodia-Forest-Image-2-1024x1024.jpg", 
				"C:\\Users\\Meg\\Documents\\NoFireResized\\santuk_etm_2000366,jpg", "C:\\Users\\Meg\\Documents\\NoFireResized\\300px-Forest_example.png"};
		ReadXML myReadXML = new ReadXML(file);
		for (int i = 0; i < 13; i++) {
			FileInfo myFileInfo = new FileInfo(imagePathName[i], resizedImagePathName[i]);
			ImageProcessor myImageProcessor = new ImageProcessor(myReadXML, myFileInfo);
			NetworkClassifier myNetwork = new NetworkClassifier(myReadXML, myImageProcessor);
			System.out.println("Hidden unit count " + myReadXML.getHiddenUnitCount());
			System.out.println("Get hidden units length: " + myNetwork.getHiddenUnits().length);
			//for (int j = 0; j < 42; j++) {
				//System.out.print(myNetwork.getHiddenUnits()[j] + " ");
			//}
			System.out.println();
			myNetwork.determineFire();
		}
	}
	
	public static void main(String[] args) throws IOException {
		ClassifierProject myClassifierProject = new ClassifierProject();
	}

}
