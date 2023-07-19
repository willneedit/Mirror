#!/bin/bash

PKG_ROOT=Assets/Mirror

git branch -D tmp &> /dev/null || echo "tmp branch not found (but it's okay)"
git branch -D package &> /dev/null || echo "package branch not found (but it's okay)"

hash=$(git show --format="%H (%s)" -s)
git checkout --orphan tmp
git commit -am "Orphaned from ${hash}"
git subtree split -P "$PKG_ROOT" -b package
git checkout package
if [[ -d "Samples" ]]; then
  git mv Samples Samples~
  rm -f Samples.meta
  git commit -am "fix: Samples => Samples~"
fi
if [[ -d "Tests" ]]; then
  git mv Tests Tests~
  rm -f Tests.meta
  git commit -am "fix: Tests => Tests~"
fi
