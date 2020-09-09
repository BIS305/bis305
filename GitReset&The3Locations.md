Git Reset & the Three Locations
========
<sup>Adapted from https://git-scm.com/book/en/v2/Git-Tools-Reset-Demystified</sup>

[Introduction](#introduction)

[Soft Reset](#soft-reset)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[How Can This Help Me?](#how-can-this-help-me)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Reset Back to 3rd Commit](#reset-back-to-3rd-commit)

[Mixed Reset (Default)](#mixed-reset-default)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[How Can This Help Me?](#how-can-this-help-me-1)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Reset Back to 3rd Commit](#reset-back-to-3rd-commit-1)

[Hard Reset](#hard-reset)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[How Can This Help Me?](#how-can-this-help-me-2)

Introduction
============

An easier way to think about reset is through the mental frame of Git
being a content manager of three different locations. By "location"
here, we really mean "collection of files", not specifically the data
structure.

Git as a system manages and manipulates three locations in its normal
operation:

|**Location**       |**Role**                                                                |
|-------------------|------------------------------------------------------------------------|
| HEAD              | Last commit snapshot (that will also be the parent of the next commit) |
| Stage (Index)     | Proposed next commit snapshot                                          |
| Working Directory | Sandbox                                                                |

The reset command overwrites these three locations in a specific order,
stopping when you tell it to:

1\. Move the branch HEAD points to (stop here if \--soft).

2\. Make the index look like HEAD (stop here unless \--hard).

3\. Make the working directory look like the index.

First, assuming that you are on a Windows machine, let us run the
createResetCommits.ps1 PowerShell script contained in the
<https://github.com/BIS305/bis305> repo. This will create a folder named
test, creates an empty Git repository in test, and then creates with 3
commits in the Git repository.

After running the PowerShell script, here is the repo history in the
test folder (Note I have an alias lg set to run a custom log listing
instead of the normal git log command):

![](.//reset_images/image1.png)

Check the status:

![](.//reset_images/image2.png)

And then, check the working tree content:

![](.//reset_images/image3.png)

Here is a picture of the state of the repo and locations:

![A screenshot of a cell phone Description automatically
generated](.//reset_images/image4.PNG)

So, we see the content of the repo HEAD, stage, and working tree is the
same.

Soft Reset
==========

Now, let us do a soft reset to the previous commit:

![](.//reset_images/image5.png)

Check the repo history:

![](.//reset_images/image6.png)

As you can see, the HEAD is now pointing the 2nd commit.

Check the status:

![](.//reset_images/image7.png)

We see above from the status that because the repo HEAD is pointing to
the 2nd commit of File.txt v2, stage with the content of File.txt v3 is
considered uncommitted.

Looking at the working tree, we see that it is unchanged, as it still
has File.txt v3:

![](.//reset_images/image3.png)

Here is a picture of the state of the repo and locations:

![A screenshot of a cell phone Description automatically
generated](.//reset_images/image8.PNG)

In summary, the soft reset moved the branch HEAD points to and that is
all.

How Can This Help Me?
---------------------

Since this results in the HEAD pointing to the 2nd commit and stage
having the uncommitted File.txt v3, you can

-   Add additional content to staging with File.txt v3 that you omitted
    on the last commit thereby creating a new commit.

Reset Back to 3rd Commit
--------------------------

To reset the state of the repo, stage, and working tree to its original
state of 3 commits, do a hard reset to the last commit\'s SHA1 value:

![](.//reset_images/image9.png)

Looking at the repo history we see that it is at the state of the 3rd
commit:

![](.//reset_images/image1.png)

Also, looking at the repo status we see that the repo HEAD, stage, and
working tree are reset to its state of the 3rd commit:

![](.//reset_images/image2.png)

Just to be sure, check the working tree content again:

![](.//reset_images/image3.png)

OK, we are back to your starting state of 3 commits.

Here is a picture of the state of the repo and locations:

![A screenshot of a cell phone Description automatically
generated](.//reset_images/image4.PNG)

Mixed Reset (Default)
=====================

Next, we will do a mixed reset to HEAD\'s previous commit. You can
either type the \--mixed switch or not include it as the reset command
uses that by default:

![](.//reset_images/image10.png)

Check the repo history:

![](.//reset_images/image11.png)

So, we see that concerning the repo, soft and mixed reset are identical.
However, looking at the repo status:

![](.//reset_images/image12.png)

Here we see that stage was updated with the 919b664 (2nd) commit
content, File.txt v2, and therefore File.txt v3 in the working tree is
now considered untracked as it is different that the repo history and
stage content.

Concerning the working tree, we expect it to be unchanged in a mixed
reset. Let\'s check:

![](.//reset_images/image3.png)

Yes, it is unchanged.

Here is a picture of the state of the repo and locations:

![A screenshot of a cell phone Description automatically
generated](.//reset_images/image13.PNG)

In summary, the \--mixed reset command first moved the branch HEAD
points to and then made the index content look like the HEAD\'s content.

How Can This Help Me?
---------------------

Since this results in File.txt v3 in the working tree now considered as
untracked you can:

-   Make updates to the File.txt v3, add it to stage, then commit.

-   Add additional content to the working directory, add it to stage,
    then commit.

-   Remove File.txt v3 from the working directory.

Reset Back to 3rd Commit
--------------------------

Next, we will look at a hard reset to reset the state of the repo,
stage, and working tree to its original state of 3 commits using the 3rd
commit\'s SHA1 value:

![](.//reset_images/image9.png)

Because the repo HEAD, stage, and working tree have the same content
because of the hard reset, the git status command shows that nothing
needs to be done to stage or commit content:

![](.//reset_images/image2.png)

Here is a picture of the state of the repo and locations:

![A screenshot of a cell phone Description automatically
generated](.//reset_images/image4.PNG)

Hard Reset
==========

You have just seen a hard reset to the 3rd commit, now let\'s do a hard
reset from where the HEAD is currently pointing, the 3rd commit, to the
HEAD\'s parent, the second commit. We will do this with the SHA1 check
sum value of the 2^nd^ commit, 919b664:

![](.//reset_images/image14.png)

Again, check the repo history and we see it changed from the 3rd to the
2nd commit:

![](.//reset_images/image15.png)

Looking at the repo status we see that the repo HEAD, stage, and working
tree are all reset to the content of the 2nd commit:

![](.//reset_images/image2.png)

Finally, let us check that the working tree content is now reset to the
content of the 2nd commit:

![](.//reset_images/image16.png)

Yes, it is as the File.txt v3 has been removed by the hard reset to the
content of the 2nd commit, File.txt v2.

Here is a picture of the state of the repo and locations:

![A screenshot of a cell phone Description automatically
generated](.//reset_images/image17.PNG)

In summary, the \--hard reset command first moved the branch HEAD points
to, then made the index content look like the HEAD\'s content, and
finally made the working directory look like the index.

How Can This Help Me?
---------------------

Since this results in File.txt v2 in all three locations you can:

-   Redo the contents of File.txt v3, stage the new content, and commit.

-   Create completely new content for the next commit.
