// Decompiled with JetBrains decompiler
// Type: ProjectM.NameGeneratorSourceAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class NameGeneratorSourceAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NamePrefixes;
    private static readonly System.IntPtr NativeFieldInfoPtr_NamePostfixes;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728700, XrefRangeEnd = 728701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NameGeneratorSourceAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NameGeneratorSourceAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728701, XrefRangeEnd = 728801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NameGeneratorSourceAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NameGeneratorSourceAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NameGeneratorSourceAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NameGeneratorSourceAsset()
    {
      Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (NameGeneratorSourceAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr);
      NameGeneratorSourceAsset.NativeFieldInfoPtr_NamePrefixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr, nameof (NamePrefixes));
      NameGeneratorSourceAsset.NativeFieldInfoPtr_NamePostfixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr, nameof (NamePostfixes));
      NameGeneratorSourceAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr, nameof (_Guid));
      NameGeneratorSourceAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr, 100664532);
      NameGeneratorSourceAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr, 100664533);
      NameGeneratorSourceAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr, 100664534);
      NameGeneratorSourceAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr, 100664535);
    }

    public NameGeneratorSourceAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<LocalizationKey> NamePrefixes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NameGeneratorSourceAsset.NativeFieldInfoPtr_NamePrefixes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<LocalizationKey>) null : new Il2CppStructArray<LocalizationKey>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NameGeneratorSourceAsset.NativeFieldInfoPtr_NamePrefixes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<LocalizationKey> NamePostfixes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NameGeneratorSourceAsset.NativeFieldInfoPtr_NamePostfixes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<LocalizationKey>) null : new Il2CppStructArray<LocalizationKey>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NameGeneratorSourceAsset.NativeFieldInfoPtr_NamePostfixes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NameGeneratorSourceAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NameGeneratorSourceAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [ObfuscatedName("ProjectM.NameGeneratorSourceAsset/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__7_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__7_0_Internal_Int32_LocalizationKey_LocalizationKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__7_1_Internal_Int32_LocalizationKey_LocalizationKey_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameGeneratorSourceAsset.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NameGeneratorSourceAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728697, XrefRangeEnd = 728700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _Convert_b__7_0(LocalizationKey x, LocalizationKey y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NameGeneratorSourceAsset.__c.NativeMethodInfoPtr__Convert_b__7_0_Internal_Int32_LocalizationKey_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _Convert_b__7_1(LocalizationKey x, LocalizationKey y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NameGeneratorSourceAsset.__c.NativeMethodInfoPtr__Convert_b__7_1_Internal_Int32_LocalizationKey_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<NameGeneratorSourceAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameGeneratorSourceAsset>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameGeneratorSourceAsset.__c>.NativeClassPtr);
        NameGeneratorSourceAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameGeneratorSourceAsset.__c>.NativeClassPtr, "<>9");
        NameGeneratorSourceAsset.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameGeneratorSourceAsset.__c>.NativeClassPtr, "<>9__7_0");
        NameGeneratorSourceAsset.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameGeneratorSourceAsset.__c>.NativeClassPtr, "<>9__7_1");
        NameGeneratorSourceAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGeneratorSourceAsset.__c>.NativeClassPtr, 100664537);
        NameGeneratorSourceAsset.__c.NativeMethodInfoPtr__Convert_b__7_0_Internal_Int32_LocalizationKey_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGeneratorSourceAsset.__c>.NativeClassPtr, 100664538);
        NameGeneratorSourceAsset.__c.NativeMethodInfoPtr__Convert_b__7_1_Internal_Int32_LocalizationKey_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGeneratorSourceAsset.__c>.NativeClassPtr, 100664539);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe NameGeneratorSourceAsset.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(NameGeneratorSourceAsset.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NameGeneratorSourceAsset.__c) null : new NameGeneratorSourceAsset.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(NameGeneratorSourceAsset.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<LocalizationKey> __9__7_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(NameGeneratorSourceAsset.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<LocalizationKey>) null : new Il2CppSystem.Comparison<LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(NameGeneratorSourceAsset.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<LocalizationKey> __9__7_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(NameGeneratorSourceAsset.__c.NativeFieldInfoPtr___9__7_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<LocalizationKey>) null : new Il2CppSystem.Comparison<LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(NameGeneratorSourceAsset.__c.NativeFieldInfoPtr___9__7_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
