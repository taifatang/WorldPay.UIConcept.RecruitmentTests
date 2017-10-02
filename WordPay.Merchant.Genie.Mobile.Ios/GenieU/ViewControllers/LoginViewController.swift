//
//  LoginViewController.swift
//  GenieU
//
//  Created by Tai Fa Tang on 01/10/2017.
//  Copyright © 2017 The Pocket Company. All rights reserved.
//

import UIKit

class LoginViewController: UIViewController {
    
    let loginUrl = "http://worldpaygenie.azurewebsites.net/api/genie/authorize"
    
    private var httpService: HttpService!
    
    @IBOutlet weak var pinTextField: UITextField!
    @IBOutlet weak var loginButton: UIButton!
    
    @IBAction func DoLogin(_ sender: UIButton) {
        login()
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()
        httpService = HttpService()
    }
    
    func login() {
        guard let pin = pinTextField.text else { return }
        let loginModel = LoginRequestModel(secret: pin)
        var request = URLRequest(url: URL(string: loginUrl)!)
        request.httpMethod = "POST"
        
        do {
            request.httpBody = try JSONSerialization.data(withJSONObject: loginModel, options: .prettyPrinted) // pass dictionary to nsdata object and set it as request body
        } catch let error {
            print(error.localizedDescription)
        }
        
        let task = URLSession.shared.dataTask(with: request as URLRequest, completionHandler: { data, response, error in
            
            guard error == nil else {
                return
            }
            
            guard let data = data else {
                return
            }
            
            do {
                if let json = try JSONSerialization.jsonObject(with: data, options: .mutableContainers) as? [String: Any] {
                }
            } catch let error {
                print(error.localizedDescription)
            }
        })
        task.resume()
    }
}
