// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningStormTypeSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.LightningStorm
{
  [Serializable]
  public class LightningStormTypeSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StrikeRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomPositionWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_RateModifierCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_RateModifierCurveDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_RateModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightningStrikes;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Void_byref_BlobBuilder_byref_LightningStormStrikeSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1116824, RefRangeEnd = 1116828, XrefRangeStart = 1116796, XrefRangeEnd = 1116824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(ref BlobBuilder builder, ref LightningStormStrikeSettings settings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref builder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormTypeSettings.NativeMethodInfoPtr_Convert_Public_Void_byref_BlobBuilder_byref_LightningStormStrikeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116828, XrefRangeEnd = 1116841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LightningStormTypeSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormTypeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LightningStormTypeSettings()
    {
      Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningStormTypeSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr);
      LightningStormTypeSettings.NativeFieldInfoPtr_StrikeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr, nameof (StrikeRate));
      LightningStormTypeSettings.NativeFieldInfoPtr_RandomPositionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr, nameof (RandomPositionWeight));
      LightningStormTypeSettings.NativeFieldInfoPtr_RateModifierCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr, nameof (RateModifierCurve));
      LightningStormTypeSettings.NativeFieldInfoPtr_RateModifierCurveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr, nameof (RateModifierCurveDuration));
      LightningStormTypeSettings.NativeFieldInfoPtr_RateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr, nameof (RateModifier));
      LightningStormTypeSettings.NativeFieldInfoPtr_LightningStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr, nameof (LightningStrikes));
      LightningStormTypeSettings.NativeMethodInfoPtr_Convert_Public_Void_byref_BlobBuilder_byref_LightningStormStrikeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr, 100688501);
      LightningStormTypeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr, 100688502);
    }

    public LightningStormTypeSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MinMaxFloat StrikeRate
    {
      get
      {
        return *(MinMaxFloat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_StrikeRate));
      }
      [param: In] set
      {
        *(MinMaxFloat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_StrikeRate)) = value;
      }
    }

    public unsafe float RandomPositionWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_RandomPositionWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_RandomPositionWeight)) = value;
      }
    }

    public unsafe CurveReference RateModifierCurve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_RateModifierCurve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_RateModifierCurve)) = value;
      }
    }

    public unsafe float RateModifierCurveDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_RateModifierCurveDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_RateModifierCurveDuration)) = value;
      }
    }

    public unsafe MinMaxFloat RateModifier
    {
      get
      {
        return *(MinMaxFloat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_RateModifier));
      }
      [param: In] set
      {
        *(MinMaxFloat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_RateModifier)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<LightningStrikeSettings> LightningStrikes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_LightningStrikes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LightningStrikeSettings>) null : new Il2CppReferenceArray<LightningStrikeSettings>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormTypeSettings.NativeFieldInfoPtr_LightningStrikes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormTypeSettings/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__6_0_Internal_Single_LightningStrikeSettings_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormTypeSettings.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormTypeSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe float _Convert_b__6_0(LightningStrikeSettings strike)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) strike);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormTypeSettings.__c.NativeMethodInfoPtr__Convert_b__6_0_Internal_Single_LightningStrikeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<LightningStormTypeSettings.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormTypeSettings>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormTypeSettings.__c>.NativeClassPtr);
        LightningStormTypeSettings.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeSettings.__c>.NativeClassPtr, "<>9");
        LightningStormTypeSettings.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeSettings.__c>.NativeClassPtr, "<>9__6_0");
        LightningStormTypeSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormTypeSettings.__c>.NativeClassPtr, 100688504);
        LightningStormTypeSettings.__c.NativeMethodInfoPtr__Convert_b__6_0_Internal_Single_LightningStrikeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormTypeSettings.__c>.NativeClassPtr, 100688505);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe LightningStormTypeSettings.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormTypeSettings.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (LightningStormTypeSettings.__c) null : new LightningStormTypeSettings.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormTypeSettings.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<LightningStrikeSettings, float> __9__6_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormTypeSettings.__c.NativeFieldInfoPtr___9__6_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<LightningStrikeSettings, float>) null : new Il2CppSystem.Func<LightningStrikeSettings, float>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormTypeSettings.__c.NativeFieldInfoPtr___9__6_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
