﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.NoFadeOutComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public class NoFadeOutComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768907, XrefRangeEnd = 768910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(NoFadeOutComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NoFadeOutComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoFadeOutComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NoFadeOutComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NoFadeOutComponent()
    {
      Il2CppClassPointerStore<NoFadeOutComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Presentation", nameof (NoFadeOutComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoFadeOutComponent>.NativeClassPtr);
      NoFadeOutComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoFadeOutComponent>.NativeClassPtr, 100668031);
      NoFadeOutComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoFadeOutComponent>.NativeClassPtr, 100668032);
    }

    public NoFadeOutComponent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
