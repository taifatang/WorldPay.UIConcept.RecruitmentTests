//
//  DashboardViewController.swift
//  GenieU
//
//  Created by Tai Fa Tang on 27/09/2017.
//  Copyright © 2017 The Pocket Company. All rights reserved.
//

import UIKit

class DashboardViewController: UIViewController {
    
    var httpService: HttpService!
    var accounts = [Account]()
    
    @IBOutlet weak var pocketMoney: UILabel!
    @IBOutlet weak var accountsTable: UITableView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        httpService = HttpService()
        
        accountsTable.dataSource = self
        
        getAccounts()
        accountsTable.reloadData()
    }
    
    func getAccounts() {
        for i in 0..<10 {
            let account = Account(title: "\(i)")
            accounts.append(account)
        }
    }
}

//MARK: - DataSource
extension DashboardViewController: UITableViewDataSource {
    
    func numberOfSections(in tableView: UITableView) -> Int {
        return 1
    }
    
    func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return accounts.count
    }
    
    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        guard let cell = tableView
            .dequeueReusableCell(withIdentifier: "accountTableCell", for: indexPath) as? AccountTableViewCell else {
            fatalError("")
        }
        
        let account = accounts[indexPath.row]
        
        cell.bankNameLabel.text = account.title
        
        return cell
    }
    
}

//MARK: - TableViewDelegate
extension DashboardViewController: UITableViewDelegate {
    
}
