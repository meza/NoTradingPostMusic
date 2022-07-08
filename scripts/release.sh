#!/bin/sh

VERSION=$1

echo "Replacing version with ${VERSION}"
sed -e "s/VERSION/${VERSION}/" -i NoTradingPostMusic/modinfo.json
cd NoTradingPostMusic
zip -qq -r ../NoTradingPostMusic.rmod . -x '*.csproj' -x '*.rmod'

