﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyVFXPrefabComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public class ProxyVFXPrefabComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112223, XrefRangeEnd = 1112231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProxyVFXPrefabComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProxyVFXPrefabComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProxyVFXPrefabComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProxyVFXPrefabComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProxyVFXPrefabComponent()
    {
      Il2CppClassPointerStore<ProxyVFXPrefabComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyVFXPrefabComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyVFXPrefabComponent>.NativeClassPtr);
      ProxyVFXPrefabComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXPrefabComponent>.NativeClassPtr, 100688054);
      ProxyVFXPrefabComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXPrefabComponent>.NativeClassPtr, 100688055);
    }

    public ProxyVFXPrefabComponent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
