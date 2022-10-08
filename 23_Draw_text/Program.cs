string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeigthPosition = Console.WindowHeight / 2;

DrawText(caption, screenWidthPosition, screenHeigthPosition);

DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeigthPosition
);

// TODO: закончить программу!