#!/bin/bash

if ["$#" -eq 2]; then
    echo "bonjour $2 $1 et bonne journée !"
    else
    echo "Utilisation : $0 nom prénom" >&2
    exit 1
fi

