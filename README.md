# mvcmoviecore2

To initially import this may help fix the remote deploy
git add .
git commit -m "added README.md"

git branch -M main

Test Merge
Do I see changes here?
To Fix problems

git push -u origin main -f

To get latest code
    Prefered
    
git fetch origin

git checkout origin/yourbranch

git merge origin/yourbranch


or
git checkout branch1

clone branch
git clone --branch Branch1 https://github.com/dkdavis11/mvcmoviecore.git


Detached head means you are no longer on a branch, you have checked out a single commit in the history (in this case the commit previous to HEAD, i.e. HEAD^).


You only need to checkout the branch you were on, e.g.


git checkout master
