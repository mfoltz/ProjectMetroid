// Decompiled with JetBrains decompiler
// Type: ProjectM.Unit_StatsSettings_EditorData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class Unit_StatsSettings_EditorData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitBaseStatsType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueMax;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Unit_StatsSettings_EditorData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unit_StatsSettings_EditorData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Unit_StatsSettings_EditorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Unit_StatsSettings_EditorData()
    {
      Il2CppClassPointerStore<Unit_StatsSettings_EditorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Unit_StatsSettings_EditorData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unit_StatsSettings_EditorData>.NativeClassPtr);
      Unit_StatsSettings_EditorData.NativeFieldInfoPtr_UnitBaseStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unit_StatsSettings_EditorData>.NativeClassPtr, nameof (UnitBaseStatsType));
      Unit_StatsSettings_EditorData.NativeFieldInfoPtr_CurveAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unit_StatsSettings_EditorData>.NativeClassPtr, nameof (CurveAsset));
      Unit_StatsSettings_EditorData.NativeFieldInfoPtr_ValueMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unit_StatsSettings_EditorData>.NativeClassPtr, nameof (ValueMin));
      Unit_StatsSettings_EditorData.NativeFieldInfoPtr_ValueMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unit_StatsSettings_EditorData>.NativeClassPtr, nameof (ValueMax));
      Unit_StatsSettings_EditorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unit_StatsSettings_EditorData>.NativeClassPtr, 100666019);
    }

    public Unit_StatsSettings_EditorData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnitBaseStatsType UnitBaseStatsType
    {
      get
      {
        return *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_EditorData.NativeFieldInfoPtr_UnitBaseStatsType));
      }
      [param: In] set
      {
        *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_EditorData.NativeFieldInfoPtr_UnitBaseStatsType)) = value;
      }
    }

    public unsafe CurveInstance CurveAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_EditorData.NativeFieldInfoPtr_CurveAsset));
        return pointer == System.IntPtr.Zero ? (CurveInstance) null : new CurveInstance(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_EditorData.NativeFieldInfoPtr_CurveAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float ValueMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_EditorData.NativeFieldInfoPtr_ValueMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_EditorData.NativeFieldInfoPtr_ValueMin)) = value;
      }
    }

    public unsafe float ValueMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_EditorData.NativeFieldInfoPtr_ValueMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_EditorData.NativeFieldInfoPtr_ValueMax)) = value;
      }
    }
  }
}
