﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.RecipeOutputItemComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class RecipeOutputItemComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_OutputItem;
    private static readonly IntPtr NativeFieldInfoPtr_OutputStacks;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(RecipeOutputItemComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992967, XrefRangeEnd = 992968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RecipeOutputItemComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeOutputItemComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeOutputItemComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RecipeOutputItemComponent()
    {
      Il2CppClassPointerStore<RecipeOutputItemComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RecipeOutputItemComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeOutputItemComponent>.NativeClassPtr);
      RecipeOutputItemComponent.NativeFieldInfoPtr_OutputItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeOutputItemComponent>.NativeClassPtr, nameof (OutputItem));
      RecipeOutputItemComponent.NativeFieldInfoPtr_OutputStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeOutputItemComponent>.NativeClassPtr, nameof (OutputStacks));
      RecipeOutputItemComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeOutputItemComponent>.NativeClassPtr, 100676666);
      RecipeOutputItemComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeOutputItemComponent>.NativeClassPtr, 100676667);
    }

    public RecipeOutputItemComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ItemDataComponent OutputItem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeOutputItemComponent.NativeFieldInfoPtr_OutputItem));
        return pointer == IntPtr.Zero ? (ItemDataComponent) null : new ItemDataComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeOutputItemComponent.NativeFieldInfoPtr_OutputItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int OutputStacks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeOutputItemComponent.NativeFieldInfoPtr_OutputStacks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeOutputItemComponent.NativeFieldInfoPtr_OutputStacks)) = value;
      }
    }
  }
}
