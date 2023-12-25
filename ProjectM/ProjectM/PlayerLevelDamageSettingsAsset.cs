// Decompiled with JetBrains decompiler
// Type: ProjectM.PlayerLevelDamageSettingsAsset
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
  public class PlayerLevelDamageSettingsAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1067553, RefRangeEnd = 1067554, XrefRangeStart = 1067502, XrefRangeEnd = 1067553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(Entity entity, EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerLevelDamageSettingsAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerLevelDamageSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerLevelDamageSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayerLevelDamageSettingsAsset()
    {
      Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlayerLevelDamageSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset>.NativeClassPtr);
      PlayerLevelDamageSettingsAsset.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset>.NativeClassPtr, nameof (Settings));
      PlayerLevelDamageSettingsAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset>.NativeClassPtr, 100683975);
      PlayerLevelDamageSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset>.NativeClassPtr, 100683976);
    }

    public PlayerLevelDamageSettingsAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PlayerLevelDamageSettingsAsset.PlayerLevelDamageSettingsArray Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLevelDamageSettingsAsset.NativeFieldInfoPtr_Settings));
        return pointer == System.IntPtr.Zero ? (PlayerLevelDamageSettingsAsset.PlayerLevelDamageSettingsArray) null : new PlayerLevelDamageSettingsAsset.PlayerLevelDamageSettingsArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerLevelDamageSettingsAsset.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class PlayerLevelDamageSettingsArray : ReorderableArray<PlayerLevelDamageSettings>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067499, XrefRangeEnd = 1067502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PlayerLevelDamageSettingsArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.PlayerLevelDamageSettingsArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerLevelDamageSettingsAsset.PlayerLevelDamageSettingsArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PlayerLevelDamageSettingsArray()
      {
        Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.PlayerLevelDamageSettingsArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset>.NativeClassPtr, nameof (PlayerLevelDamageSettingsArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.PlayerLevelDamageSettingsArray>.NativeClassPtr);
        PlayerLevelDamageSettingsAsset.PlayerLevelDamageSettingsArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.PlayerLevelDamageSettingsArray>.NativeClassPtr, 100683977);
      }

      public PlayerLevelDamageSettingsArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("ProjectM.PlayerLevelDamageSettingsAsset/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__2_0_Internal_Single_PlayerLevelDamageSettings_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerLevelDamageSettingsAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe float _Convert_b__2_0(PlayerLevelDamageSettings x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerLevelDamageSettingsAsset.__c.NativeMethodInfoPtr__Convert_b__2_0_Internal_Single_PlayerLevelDamageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.__c>.NativeClassPtr);
        PlayerLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.__c>.NativeClassPtr, "<>9");
        PlayerLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.__c>.NativeClassPtr, "<>9__2_0");
        PlayerLevelDamageSettingsAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.__c>.NativeClassPtr, 100683979);
        PlayerLevelDamageSettingsAsset.__c.NativeMethodInfoPtr__Convert_b__2_0_Internal_Single_PlayerLevelDamageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLevelDamageSettingsAsset.__c>.NativeClassPtr, 100683980);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe PlayerLevelDamageSettingsAsset.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayerLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (PlayerLevelDamageSettingsAsset.__c) null : new PlayerLevelDamageSettingsAsset.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayerLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<PlayerLevelDamageSettings, float> __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayerLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<PlayerLevelDamageSettings, float>) null : new Il2CppSystem.Func<PlayerLevelDamageSettings, float>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayerLevelDamageSettingsAsset.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
