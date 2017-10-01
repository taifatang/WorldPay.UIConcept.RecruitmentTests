//
//  HttpService.swift
//  GenieU
//
//  Created by Tai Fa Tang on 26/09/2017.
//  Copyright © 2017 The Pocket Company. All rights reserved.
//

import Foundation

class HttpService {
    
    let session = URLSession.shared
    
    func get<T>(with request: URLRequest, completionHandler: @escaping (T?, Error?) -> ()) where T: Codable {
        let task = session.dataTask(with: request) { (data, response, error) in
            
            guard error == nil else {
                completionHandler(nil, error)
                return
            }
            
            guard let responseData = data else {
                completionHandler(nil, error)
                return
            }
            
            let decoder = JSONDecoder()
            
            do {
                let data = try decoder.decode(T.self, from: responseData)
                completionHandler(data, nil)
            } catch {
                completionHandler(nil, error)
            }
        }
        task.resume()
    }
    
    func Post<T>(with request: URLRequest, completionHandler: @escaping (T?, Error?) -> ()) where T: Codable {
        let task = session.dataTask(with: request) { (data, response, error) in
            
            guard error == nil else {
                completionHandler(nil, error)
                return
            }
            
            guard let responseData = data else {
                completionHandler(nil, error)
                return
            }
            
            let decoder = JSONDecoder()
            
            do {
                let data = try decoder.decode(T.self, from: responseData)
                completionHandler(data, nil)
            } catch {
                completionHandler(nil, error)
            }
        }
        task.resume()
    }
}
