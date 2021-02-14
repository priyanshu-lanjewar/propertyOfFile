<h1> Property Of File </h1> <br>
<ul>
  <li> It is a simple <b>cloud based</b> appication devloped in Microsoft Visual Studio 19 written in language C#.
<li> This is a simple app that requires a .docx word file as Input and displays total number of pages, words, character (with and without spaces), special characters, uppercase and lowercase Symbols.
<li> This Applicaton works on Aneka PaaS.
<li> This Application is an example of Aneka Thread Model Programming.
  </ul>
  
  <h2> What is Aneka ?</h2>
  
<ul>
  <li>Aneka technology primarily consists of two key components:
<ul>
<li>SDK (Software Development Kit) containing application programming interfaces (APIs) and tools essential for rapid development of applications. Aneka APIs supports three popular Cloud programming models: Task, Thread, and MapReduce.
  <li>
A Runtime Engine and Platform for managing deployment and execution of applications on private or public Clouds.
  <li> <a href="http://manjrasoft.com/index.html"> Click here to know more about Aneka </a>
    </ul></ul>

 <h2> How does it works ?</h2>
 <ul>
  <li> It works on Master - Worker model.
    <li> Initially a task is assigned to a Master Container.
      <li> Master, Depending on complexity of task distributes this task threads in multiple workers.
        <li> This workers works parallely, which speeds up the execution process.
          <li> Finally, workers submit output to master, and master combine this output and pass back to application and display it to user.
            <li> Overall process occurs on cloud itself, so no extra storage is required.
              </ul>
