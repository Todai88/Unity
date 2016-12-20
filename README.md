<h1><b>Unity</b></h1>

This will serve as a repository for me to track my progress throughout my Unity development.
I'm also hoping to add some nice resources later on.

<ol>

<h2><li><b>Number Wizard (console game):</b></li></h2>

<ul>

<h3><li> Problem:</li></h3>
	Deliver a simple number guessing game where the user thinks of a number and the 
	computer attemps to find the number by asking the user if the number is higher
	or lower than a guess. 

<h3><li> Problem:</li></h3>
	I solved this by implementing basic refractoring instead of rewriting
	already implemented code. <br/>
	The core code is quite basic; it uses <code>Update()</code> to 
	capture <b><code>KeyDown</code>-events</b> (up/down-arrow and return).<br/>
	If return is pushed the user is prompted to play again,
	if the user pushes return again the game resets by calling
	<code>StartingGame</code> which resets all the global variables.<br/>
	If up/down-arrow is pushed, the variables are manipulated
	and a basic calculation takes place (<code>(min + max) / 2 </code>).
	This continues to happen until the program has guessed the correct number.
<h3><li> Learning outcomes: </li></h3>
	Quite a basic assignment, really. 
	<br/><br/>
	I've got experience using C# and .NET.
	The only real problem I faced was working with Unity's
	<b><code>GetKeyDown</code>-events.</b>
	<br/>
	Mainly I had a problem restaring the game loop, since
	both confirming that a number was correct and 
	confirming that you wish to play again use
	<code>KeyCode.Return</code>.
	So what I sorted that out by adding a 
	boolean (`flag`) to handle the state
	as well as 'flushing' the current <b><code>Input</code>-buffer</b>
	by using <code>Input.ResetInputAxes()</code>.
</ul>

</ol>
