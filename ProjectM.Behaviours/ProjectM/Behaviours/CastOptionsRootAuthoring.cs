// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionsRootAuthoring
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Behaviours
{
  public class CastOptionsRootAuthoring : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitPrefab;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335826, XrefRangeEnd = 1335954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastOptionsRootAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastOptionsRootAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastOptionsRootAuthoring()
    {
      Il2CppClassPointerStore<CastOptionsRootAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionsRootAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionsRootAuthoring>.NativeClassPtr);
      CastOptionsRootAuthoring.NativeFieldInfoPtr_UnitPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsRootAuthoring>.NativeClassPtr, nameof (UnitPrefab));
      CastOptionsRootAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring>.NativeClassPtr, 100664412);
      CastOptionsRootAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring>.NativeClassPtr, 100664413);
    }

    public CastOptionsRootAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<AbilityBarComponent> UnitPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsRootAuthoring.NativeFieldInfoPtr_UnitPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<AbilityBarComponent>) null : new WeakAssetReference<AbilityBarComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsRootAuthoring.NativeFieldInfoPtr_UnitPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.CastOptionsRootAuthoring/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_4;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_5;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_6;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__1_0_Internal_IEnumerable_1_CastOptionGroup_CastOptionsAuthoring_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__1_1_Internal___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOptionsAuthoring_CastOptionGroup_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__1_2_Internal_IEnumerable_1_CastOption___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__1_3_Internal___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__1_4_Internal___f__AnonymousType2_2___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_Single___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__1_5_Internal_Single___f__AnonymousType2_2___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__1_6_Internal_Single___f__AnonymousType2_2___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_Single_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe IEnumerable<CastOptionsAuthoring.CastOptionGroup> _Convert_b__1_0(
        CastOptionsAuthoring authoring)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_0_Internal_IEnumerable_1_CastOptionGroup_CastOptionsAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<CastOptionsAuthoring.CastOptionGroup>) null : new IEnumerable<CastOptionsAuthoring.CastOptionGroup>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335804, XrefRangeEnd = 1335810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup> _Convert_b__1_1(
        CastOptionsAuthoring authoring,
        CastOptionsAuthoring.CastOptionGroup grp)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) grp);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_1_Internal___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOptionsAuthoring_CastOptionGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>) null : new __f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335810, XrefRangeEnd = 1335811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe IEnumerable<CastOptionsAuthoring.CastOption> _Convert_b__1_2(
        __f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup> _param1)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_2_Internal_IEnumerable_1_CastOption___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<CastOptionsAuthoring.CastOption>) null : new IEnumerable<CastOptionsAuthoring.CastOption>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335811, XrefRangeEnd = 1335817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption> _Convert_b__1_3(
        __f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup> _param1,
        CastOptionsAuthoring.CastOption castOption)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) castOption);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_3_Internal___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>) null : new __f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335817, XrefRangeEnd = 1335824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float> _Convert_b__1_4(
        __f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption> _param1)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_4_Internal___f__AnonymousType2_2___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_Single___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (__f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>) null : new __f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335824, XrefRangeEnd = 1335825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe float _Convert_b__1_5(
        __f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float> _param1)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_5_Internal_Single___f__AnonymousType2_2___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335825, XrefRangeEnd = 1335826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe float _Convert_b__1_6(
        __f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float> _param1)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_6_Internal_Single___f__AnonymousType2_2___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionsRootAuthoring>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr);
        CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, "<>9");
        CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, "<>9__1_0");
        CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, "<>9__1_1");
        CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, "<>9__1_2");
        CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, "<>9__1_3");
        CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, "<>9__1_4");
        CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, "<>9__1_5");
        CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, "<>9__1_6");
        CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, 100664415);
        CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_0_Internal_IEnumerable_1_CastOptionGroup_CastOptionsAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, 100664416);
        CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_1_Internal___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOptionsAuthoring_CastOptionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, 100664417);
        CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_2_Internal_IEnumerable_1_CastOption___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, 100664418);
        CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_3_Internal___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, 100664419);
        CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_4_Internal___f__AnonymousType2_2___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_Single___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, 100664420);
        CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_5_Internal_Single___f__AnonymousType2_2___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, 100664421);
        CastOptionsRootAuthoring.__c.NativeMethodInfoPtr__Convert_b__1_6_Internal_Single___f__AnonymousType2_2___f__AnonymousType1_2___f__AnonymousType0_2_CastOptionsAuthoring_CastOptionGroup_CastOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsRootAuthoring.__c>.NativeClassPtr, 100664422);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe CastOptionsRootAuthoring.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (CastOptionsRootAuthoring.__c) null : new CastOptionsRootAuthoring.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<CastOptionsAuthoring, IEnumerable<CastOptionsAuthoring.CastOptionGroup>> __9__1_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CastOptionsAuthoring, IEnumerable<CastOptionsAuthoring.CastOptionGroup>>) null : new Il2CppSystem.Func<CastOptionsAuthoring, IEnumerable<CastOptionsAuthoring.CastOptionGroup>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup, __f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>> __9__1_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup, __f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>>) null : new Il2CppSystem.Func<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup, __f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, IEnumerable<CastOptionsAuthoring.CastOption>> __9__1_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, IEnumerable<CastOptionsAuthoring.CastOption>>) null : new Il2CppSystem.Func<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, IEnumerable<CastOptionsAuthoring.CastOption>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption, __f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>> __9__1_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption, __f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>>) null : new Il2CppSystem.Func<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption, __f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, __f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>> __9__1_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, __f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>>) null : new Il2CppSystem.Func<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, __f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<__f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>, float> __9__1_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<__f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>, float>) null : new Il2CppSystem.Func<__f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>, float>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<__f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>, float> __9__1_6
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_6, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<__f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>, float>) null : new Il2CppSystem.Func<__f__AnonymousType2<__f__AnonymousType1<__f__AnonymousType0<CastOptionsAuthoring, CastOptionsAuthoring.CastOptionGroup>, CastOptionsAuthoring.CastOption>, float>, float>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastOptionsRootAuthoring.__c.NativeFieldInfoPtr___9__1_6, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
