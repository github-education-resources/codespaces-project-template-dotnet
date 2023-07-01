## GitHub Copilot CLI ##
### Add GitHub Copilot CLI alias to .zshrc
echo '
# Add GitHub Copilot CLI alias to .zshrc
alias ghcp='github-copilot-cli'
eval "$(github-copilot-cli alias -- "$0")"
' >> $HOME/.zshrc

### Add GitHub Copilot CLI alias to .bashrc
echo '
# Add GitHub Copilot CLI alias to .bashrc
alias ghcp='github-copilot-cli'
eval "$(github-copilot-cli alias -- "$0")"
' >> $HOME/.bashrc

# ### Add GitHub Copilot CLI alias to PowerShell profile
# ghcp=$(which github-copilot-cli)
# sudo mkdir -p $HOME/.config/powershell
# echo "
# # Add GitHub Copilot CLI alias to PowerShell profile
# Set-Alias ghcp $ghcp
# function what-the-shell { ghcp what-the-shell \$args }
# function git-assist { ghcp git-assist \$args }
# function gh-assist { ghcp gh-assist \$args }
# Set-Alias ?? what-the-shell
# Set-Alias git? git-assist
# Set-Alias gh? gh-assist
# " | sudo tee -a $HOME/.config/powershell/Microsoft.PowerShell_profile.ps1

# ### Add GitHub Copilot CLI alias to Integrated PowerShell profile
# echo "
# # Add GitHub Copilot CLI alias to Integrated PowerShell profile
# Set-Alias ghcp $ghcp
# function what-the-shell { ghcp what-the-shell \$args }
# function git-assist { ghcp git-assist \$args }
# function gh-assist { ghcp gh-assist \$args }
# Set-Alias ?? what-the-shell
# Set-Alias git? git-assist
# Set-Alias gh? gh-assist
# " | sudo tee -a $HOME/.config/powershell/Microsoft.VSCode_profile.ps1
