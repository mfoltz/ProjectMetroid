// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitLevelDamageSettingsAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class UnitLevelDamageSettingsAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1067633, RefRangeEnd = 1067635, XrefRangeStart = 1067582, XrefRangeEnd = 1067633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(Entity entity, EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitLevelDamageSettingsAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitLevelDamageSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitLevelDamageSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitLevelDamageSettingsAsset()
    {
      Il2CppClassPointerStore<UnitLevelDamageSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UnitLevelDamageSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset>.NativeClassPtr);
      UnitLevelDamageSettingsAsset.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset>.NativeClassPtr, nameof (Settings));
      UnitLevelDamageSettingsAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset>.NativeClassPtr, 100683985);
      UnitLevelDamageSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset>.NativeClassPtr, 100683986);
    }

    public UnitLevelDamageSettingsAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnitLevelDamageSettingsAsset.UnitLevelDamageSettingsArray Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitLevelDamageSettingsAsset.NativeFieldInfoPtr_Settings));
        return pointer == System.IntPtr.Zero ? (UnitLevelDamageSettingsAsset.UnitLevelDamageSettingsArray) null : new UnitLevelDamageSettingsAsset.UnitLevelDamageSettingsArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitLevelDamageSettingsAsset.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class UnitLevelDamageSettingsArray : ReorderableArray<UnitLevelDamageSettings>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067579, XrefRangeEnd = 1067582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe UnitLevelDamageSettingsArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.UnitLevelDamageSettingsArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitLevelDamageSettingsAsset.UnitLevelDamageSettingsArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UnitLevelDamageSettingsArray()
      {
        Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.UnitLevelDamageSettingsArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset>.NativeClassPtr, nameof (UnitLevelDamageSettingsArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.UnitLevelDamageSettingsArray>.NativeClassPtr);
        UnitLevelDamageSettingsAsset.UnitLevelDamageSettingsArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.UnitLevelDamageSettingsArray>.NativeClassPtr, 100683987);
      }

      public UnitLevelDamageSettingsArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("ProjectM.UnitLevelDamageSettingsAsset/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__2_0_Internal_Single_UnitLevelDamageSettings_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitLevelDamageSettingsAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe float _Convert_b__2_0(UnitLevelDamageSettings x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitLevelDamageSettingsAsset.__c.NativeMethodInfoPtr__Convert_b__2_0_Internal_Single_UnitLevelDamageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.__c>.NativeClassPtr);
        UnitLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.__c>.NativeClassPtr, "<>9");
        UnitLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.__c>.NativeClassPtr, "<>9__2_0");
        UnitLevelDamageSettingsAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.__c>.NativeClassPtr, 100683989);
        UnitLevelDamageSettingsAsset.__c.NativeMethodInfoPtr__Convert_b__2_0_Internal_Single_UnitLevelDamageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitLevelDamageSettingsAsset.__c>.NativeClassPtr, 100683990);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe UnitLevelDamageSettingsAsset.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnitLevelDamageSettingsAsset.__c) null : new UnitLevelDamageSettingsAsset.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<UnitLevelDamageSettings, float> __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UnitLevelDamageSettings, float>) null : new Il2CppSystem.Func<UnitLevelDamageSettings, float>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
