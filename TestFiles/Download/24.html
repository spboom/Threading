if(typeof AC==="undefined"){var AC={}}AC.AutoGallery=Object.synthesize({__classNames:{wrapper:"autogallery",view:"gallery-view",content:"gallery-content"},__specialSwapViewTriggers:["next","previous","SwapViewFirstSection","SwapViewPreviousSelection"],galleries:{},slideshows:{},_classPrefix:"autogallery-",setClassPrefix:function(b){if(typeof b==="string"){this._classPrefix=b
}return this._classPrefix},initialize:function(){$$("."+this.__classNames.wrapper).each(function(b){this.__setUpGallery(b)
}.bind(this))},__setUpGallery:function(i){var l,g,h,k,j;l=this.Types.Registries.gallery.match(i,this._classPrefix);
g=l.getOptions();h=i.down("."+this.__classNames.view);if(this.__galleryViewIsValid(h)){k=i.select("."+this.__classNames.content);
k=k.concat(i.select("a."+h.id));k=this.__parseContent(k);j=l.context.viewer||AC.ViewMaster.Viewer;
this.galleries[h.id]=new j(k,h.id,h.id,g);this.galleries[h.id].__type=l;this.galleries[h.id].__wrapper=i;
this.__setUpDelegate(h,l);this.__setUpSlideshow(h,i)}},__galleryViewIsValid:function(d){if(!Object.isElement(d)){try{console.error("View element not found for gallery.")
}catch(c){}return false}if(typeof d.id!=="string"||d.id===""){try{console.error("Valid ID not found on view for gallery.")
}catch(c){}return false}if(typeof this.galleries[d.id]!=="undefined"){try{console.error('View ID "'+d.id+'" is not unique.')
}catch(c){}return false}return true},__setUpDelegate:function(h,j){var g=this,k={},l=this.__classNames.content,i;
i=function(a){if(typeof a==="object"&&a.__autogalleryAddedGalleryContentClassName!==true&&"content" in a&&Object.isElement(a.content)){a.content.addClassName(l);
a.__autogalleryAddedGalleryContentClassName=true}};k.manageZ=function(e,d,q,c,b,f){var p=(typeof c==="number")?c-1:"",a,r;
for(r in g.galleries){a=g.galleries[r];if(a.triggerClassName!==e.triggerClassName){if(a.__wrapper){a.__wrapper.style.zIndex=p
}if(a.view.view()){a.view.view().style.zIndex=p}if(a.currentSection&&a.currentSection.content){a.currentSection.content.style.zIndex=p
}}}if(typeof j.context.delegate==="object"){if(typeof j.context.delegate.manageZ==="function"){j.context.delegate.manageZ(e,d,q,c,b,f)
}}};k.willShow=function(c,a,b){i(b);if(typeof j.context.delegate==="object"){if(typeof j.context.delegate.willShow==="function"){j.context.delegate.willShow(c,a,b)
}}};k.didShow=function(c,a,b){i(b);if(typeof j.context.delegate==="object"){if(typeof j.context.delegate.didShow==="function"){j.context.delegate.didShow(c,a,b)
}}};if(typeof j.context.delegate==="object"){Object.extend(k,j.context.delegate)
}this.galleries[h.id].setDelegate(k)},__setUpSlideshow:function(e,f){var d;if(f.className.match("(^|\\s)"+this._classPrefix+"slideshow(-|\\s|$)")){d=this.Types.Registries.slideshow.match(f,this._classPrefix+"slideshow-");
this.slideshows[e.id]=new AC.ViewMaster.Slideshow(this.galleries[e.id],this._classPrefix+"slideshow-trigger",d.getOptions());
this.slideshows[e.id].__type=d}},addType:function(j,f,h,g,i){this.Types.Registries.gallery.addType(j,f,h,g,i)
},addSlideshowType:function(j,f,h,g,i){this.Types.Registries.slideshow.addType(j,f,h,g,i)
},__parseContent:function(k){var i,h,e=[],l=[];for(h=0;h<k.length;h++){if(k[h].hasClassName(this.__classNames.content)){i=k[h].getAttribute("id")
}else{i=k[h].getAttribute("href");if(!!i.match("#")){i=i.split("#")[1]}else{try{console.error("ID for trigger was not found in HREF.")
}catch(j){}}}if(typeof i==="string"&&i!==""){if(!this.__specialSwapViewTriggers.include(i)){if(!l.include(i)){l.push(i);
e.push(k[h])}}}else{try{console.error("ID for section was not valid.")}catch(j){}}}return e
},logTypes:function(){var h=0,f,e;try{console.log("----------------------------------")
}catch(g){}try{console.log("	Gallery Types")}catch(g){}try{console.log("----------------------------------")
}catch(g){}for(f in this.galleries){if(this.galleries.hasOwnProperty(f)){h++;try{console.log(h+". "+f+": "+this.galleries[f].__type.name)
}catch(g){}}}if(h===0){try{console.log("(none)")}catch(g){}}try{console.log("")
}catch(g){}h=0;try{console.log("----------------------------------")}catch(g){}try{console.log("	Slideshow Types")
}catch(g){}try{console.log("----------------------------------")}catch(g){}for(e in this.slideshows){if(this.slideshows.hasOwnProperty(e)){h++;
try{console.log(h+". "+e+": "+this.slideshows[e].__type.name)}catch(g){}}}if(h===0){try{console.log("(none)")
}catch(g){}}try{console.log("")}catch(g){}}});AC.AutoGallery.Types={};AC.AutoGallery.Types.Registry=Class.create({__reservedNames:["trigger"],initialize:function(){this.__model=[];
this.__lookup={}},addType:function(n,e,k,i,m){if(this.__reservedNames.indexOf(n)!==-1){try{console.error("Cannot add type: Type name is reserved: "+n)
}catch(j){}return}if(typeof e!=="object"){e={}}if(typeof n==="string"){var l=this.__lookup[i]||this.__lookup._base;
if(typeof this.__lookup[n]!=="undefined"){try{console.error("Cannot overwrite existing Type: "+n)
}catch(j){}return}this.__lookup[n]=new AC.AutoGallery.Types.Type(n,e,k,l,m);if(typeof this.__model[this.__lookup[n].level()]==="undefined"){this.__model[this.__lookup[n].level()]=[]
}this.__model[this.__lookup[n].level()].push(this.__lookup[n])}else{if(typeof n!=="string"){try{console.error("Cannot add type: Type Name must be a string.")
}catch(j){}}}},match:function(e,h){var f=null;if(!Object.isElement(e)){try{console.error("An element is required to match against a type.")
}catch(g){}return false}if(typeof h!=="string"){h=""}f=this.__matchName(e,h);if(f!==null){return f
}f=this.__matchQualifier(e,h);if(f!==null){return f}if(typeof this.__model[1]!=="undefined"){if(typeof this.__model[0]!=="undefined"){f=this.__model[1][0]
}else{try{console.error("Catchall Type not defined")}catch(g){}}}else{try{console.error("No non-_base types defined at index 1.")
}catch(g){}}return f},__matchName:function(j,i){var e,g;for(e=this.__model.length-1;
e>=0;e--){if(typeof this.__model[e]!=="undefined"){for(g=this.__model[e].length-1;
g>=0;g--){if(j.hasClassName(i+this.__model[e][g].name)){return this.__model[e][g]
}}}else{try{console.error("No array of types exists at this level.")}catch(h){}}}return null
},__matchQualifier:function(j,i){var e,g;for(e=this.__model.length-1;e>=0;e--){if(typeof this.__model[e]!=="undefined"){for(g=this.__model[e].length-1;
g>=0;g--){if(typeof this.__model[e][g].qualifier==="function"){if(this.__model[e][g].qualifier(j,i)===true){return this.__model[e][g]
}}else{try{console.error("Qualifier for "+this.__model[e][g].name+" is not a function.")
}catch(h){}}}}else{try{console.error("No array of types exists at this level.")
}catch(h){}}}return null},reserveName:function(d){if(typeof d==="string"){if(this.__lookup.indexOf(d)===-1){this.__reservedNames.push(d)
}else{try{console.error("Cannot reserve name: Type with name already exists.")}catch(c){}}}else{try{console.error("Cannot reserve name: Name must be a string")
}catch(c){}}}});AC.AutoGallery.Types.Type=Class.create({initialize:function(f,g,h,i,j){this.name=f;
this.options=g||{};this.qualifier=typeof h==="function"?h:Prototype.emptyFunction;
this.parent=i;this.context=j||{};this.level()},getOptions:function(){var b=(typeof this.parent==="undefined")?{}:this.parent.getOptions();
return Object.extend(b,this.options)},__level:null,level:function(){if(this.name==="_base"){return 0
}else{if(typeof this.parent==="undefined"||typeof this.parent.name==="_base"){return 1
}else{return this.parent.level()+1}}}});AC.AutoGallery.Types.Registries={};AC.AutoGallery.Types.Registries.gallery=new AC.AutoGallery.Types.Registry();
AC.AutoGallery.Types.Registries.slideshow=new AC.AutoGallery.Types.Registry();AC.AutoGallery.addType("_base",{manageZ:true,heightFromFirstSection:true,silentTriggers:true,imageLinkAutoCaptions:true,addSectionIdAsClassName:true,useHTML5Tags:true});
AC.AutoGallery.addType("image",{useKeyboardNav:true,discontinuousPreviousNext:true});
AC.AutoGallery.addType("image-fadein",{shouldAnimateFadeIn:true},Prototype.emptyFunction,"image");
AC.AutoGallery.addType("slide",{useKeyboardNav:true,discontinuousPreviousNext:true,useTouchEvents:true},function(j,h){var g,f,i;
g=j.down("."+AC.AutoGallery.__classNames.view);if(Object.isElement(g)){f=g.getWidth();
i=j.getWidth();if(f>=i*2){return true}}return false},"_base",{viewer:AC.ViewMaster.SlideViewer});
AC.AutoGallery.addType("video",{manageZ:1010,showFirstOnStopMovie:true,ensureInView:true,escapeToClose:true},function(j,i){var g,h,f;
g=j.down("."+AC.AutoGallery.__classNames.view);if(Object.isElement(g)){h=g.getAttribute("id");
if(typeof h==="string"&&typeof g.down("a."+h)!=="undefined"){return true}}return false
});AC.AutoGallery.addSlideshowType("_base",{autoplay:true,stopOnUserInteraction:true});
AC.AutoGallery.addSlideshowType("standard",{discontinuousPreviousNext:false,stopAfterReturnToSection:false});
AC.AutoGallery.addSlideshowType("hero",{autoplay:2000,delay:7000,stopAfterReturnToSection:0,discontinuousPreviousNext:false});
Event.onDOMReady(function(){if(typeof AC.ViewMaster.Tracker==="function"){if(typeof window.tracker==="undefined"){window.tracker=new AC.ViewMaster.Tracker("click")
}}else{try{console.warn("/global/scripts/view_master_tracker.js needs to be included on this page.")
}catch(b){}}AC.AutoGallery.initialize()});