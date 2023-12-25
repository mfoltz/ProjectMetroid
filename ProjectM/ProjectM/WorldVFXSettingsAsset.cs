// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldVFXSettingsAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class WorldVFXSettingsAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_RainVFXPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_SnowVFXPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_DustParticleVFXPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_StartVaultAmbienceVFXPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_FarbaneAmbienceVFXPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_DunleyAmbienceVFXPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_CursedForestAmbienceVFXPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_SilverlightHillsAmbienceVFXPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_AmplifiedRainColorGradient;
    private static readonly IntPtr NativeFieldInfoPtr_DefaultRainColorGradient;
    private static readonly IntPtr NativeFieldInfoPtr_RainMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr_SnowMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr_DustParticleMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr_StartVaultMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr_FarbaneMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr_DunleyMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr_CursedForestMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr_SilverlightHillsMinMaxSpawnRate;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084818, XrefRangeEnd = 1084819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldVFXSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldVFXSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldVFXSettingsAsset()
    {
      Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WorldVFXSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr);
      WorldVFXSettingsAsset.NativeFieldInfoPtr_RainVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (RainVFXPrefab));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_SnowVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (SnowVFXPrefab));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_DustParticleVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (DustParticleVFXPrefab));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_StartVaultAmbienceVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (StartVaultAmbienceVFXPrefab));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_FarbaneAmbienceVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (FarbaneAmbienceVFXPrefab));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_DunleyAmbienceVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (DunleyAmbienceVFXPrefab));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_CursedForestAmbienceVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (CursedForestAmbienceVFXPrefab));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_SilverlightHillsAmbienceVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (SilverlightHillsAmbienceVFXPrefab));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_AmplifiedRainColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (AmplifiedRainColorGradient));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_DefaultRainColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (DefaultRainColorGradient));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_RainMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (RainMinMaxSpawnRate));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_SnowMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (SnowMinMaxSpawnRate));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_DustParticleMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (DustParticleMinMaxSpawnRate));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_StartVaultMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (StartVaultMinMaxSpawnRate));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_FarbaneMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (FarbaneMinMaxSpawnRate));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_DunleyMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (DunleyMinMaxSpawnRate));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_CursedForestMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (CursedForestMinMaxSpawnRate));
      WorldVFXSettingsAsset.NativeFieldInfoPtr_SilverlightHillsMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, nameof (SilverlightHillsMinMaxSpawnRate));
      WorldVFXSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSettingsAsset>.NativeClassPtr, 100685447);
    }

    public WorldVFXSettingsAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject RainVFXPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_RainVFXPrefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_RainVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject SnowVFXPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_SnowVFXPrefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_SnowVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject DustParticleVFXPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DustParticleVFXPrefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DustParticleVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject StartVaultAmbienceVFXPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_StartVaultAmbienceVFXPrefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_StartVaultAmbienceVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject FarbaneAmbienceVFXPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_FarbaneAmbienceVFXPrefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_FarbaneAmbienceVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject DunleyAmbienceVFXPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DunleyAmbienceVFXPrefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DunleyAmbienceVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject CursedForestAmbienceVFXPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_CursedForestAmbienceVFXPrefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_CursedForestAmbienceVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject SilverlightHillsAmbienceVFXPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_SilverlightHillsAmbienceVFXPrefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_SilverlightHillsAmbienceVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Gradient AmplifiedRainColorGradient
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_AmplifiedRainColorGradient));
        return pointer == IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_AmplifiedRainColorGradient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Gradient DefaultRainColorGradient
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DefaultRainColorGradient));
        return pointer == IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DefaultRainColorGradient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector2 RainMinMaxSpawnRate
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_RainMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_RainMinMaxSpawnRate)) = value;
      }
    }

    public unsafe Vector2 SnowMinMaxSpawnRate
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_SnowMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_SnowMinMaxSpawnRate)) = value;
      }
    }

    public unsafe Vector2 DustParticleMinMaxSpawnRate
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DustParticleMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DustParticleMinMaxSpawnRate)) = value;
      }
    }

    public unsafe Vector2 StartVaultMinMaxSpawnRate
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_StartVaultMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_StartVaultMinMaxSpawnRate)) = value;
      }
    }

    public unsafe Vector2 FarbaneMinMaxSpawnRate
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_FarbaneMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_FarbaneMinMaxSpawnRate)) = value;
      }
    }

    public unsafe Vector2 DunleyMinMaxSpawnRate
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DunleyMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_DunleyMinMaxSpawnRate)) = value;
      }
    }

    public unsafe Vector2 CursedForestMinMaxSpawnRate
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_CursedForestMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_CursedForestMinMaxSpawnRate)) = value;
      }
    }

    public unsafe Vector2 SilverlightHillsMinMaxSpawnRate
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_SilverlightHillsMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSettingsAsset.NativeFieldInfoPtr_SilverlightHillsMinMaxSpawnRate)) = value;
      }
    }
  }
}
