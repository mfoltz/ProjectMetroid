// Decompiled with JetBrains decompiler
// Type: ProjectM.Pylonstation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Pylonstation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentRecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinutesRemaining;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasCastleItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_FuelPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleFreeClaimUntilTimePoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlotsPerLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClaimGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelUpGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_TombCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_NestCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_SafetyBoxCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrisonCellCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChangedStateThisFrame;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsProcessing_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDecaying_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExposed_Public_get_Boolean_0;
    [FieldOffset(0)]
    public PrefabGUID CurrentRecipeGuid;
    [FieldOffset(4)]
    public float Progress;
    [FieldOffset(8)]
    public int FloorCount;
    [FieldOffset(12)]
    public int ServantCount;
    [FieldOffset(16)]
    public int Level;
    [FieldOffset(20)]
    public int MinutesRemaining;
    [FieldOffset(24)]
    public bool HasCastleItems;
    [FieldOffset(28)]
    public float FuelPercentage;
    [FieldOffset(32)]
    public double CastleFreeClaimUntilTimePoint;
    [FieldOffset(40)]
    public int SlotsPerLevel;
    [FieldOffset(44)]
    public SequenceGUID ActiveSequenceGuid;
    [FieldOffset(48)]
    public SequenceGUID InactiveSequenceGuid;
    [FieldOffset(52)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(60)]
    public SequenceState InactiveSequenceState;
    [FieldOffset(68)]
    public SequenceGUID ClaimGuid;
    [FieldOffset(72)]
    public SequenceGUID LevelUpGuid;
    [FieldOffset(76)]
    public SequenceGUID DestroyGuid;
    [FieldOffset(80)]
    public PylonstationState State;
    [FieldOffset(81)]
    public byte TombCount;
    [FieldOffset(82)]
    public byte NestCount;
    [FieldOffset(83)]
    public byte SafetyBoxCount;
    [FieldOffset(84)]
    public byte PrisonCellCount;
    [FieldOffset(85)]
    public bool ChangedStateThisFrame;

    public unsafe bool IsProcessing
    {
      [CallerCount(22), CachedScanResults(RefRangeStart = 747798, RefRangeEnd = 747820, XrefRangeStart = 747798, XrefRangeEnd = 747798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pylonstation.NativeMethodInfoPtr_get_IsProcessing_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsDecaying
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 747822, RefRangeEnd = 747831, XrefRangeStart = 747820, XrefRangeEnd = 747822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pylonstation.NativeMethodInfoPtr_get_IsDecaying_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsExposed
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 747831, RefRangeEnd = 747836, XrefRangeStart = 747831, XrefRangeEnd = 747831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pylonstation.NativeMethodInfoPtr_get_IsExposed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static Pylonstation()
    {
      Il2CppClassPointerStore<Pylonstation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Pylonstation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr);
      Pylonstation.NativeFieldInfoPtr_CurrentRecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (CurrentRecipeGuid));
      Pylonstation.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (Progress));
      Pylonstation.NativeFieldInfoPtr_FloorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (FloorCount));
      Pylonstation.NativeFieldInfoPtr_ServantCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (ServantCount));
      Pylonstation.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (Level));
      Pylonstation.NativeFieldInfoPtr_MinutesRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (MinutesRemaining));
      Pylonstation.NativeFieldInfoPtr_HasCastleItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (HasCastleItems));
      Pylonstation.NativeFieldInfoPtr_FuelPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (FuelPercentage));
      Pylonstation.NativeFieldInfoPtr_CastleFreeClaimUntilTimePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (CastleFreeClaimUntilTimePoint));
      Pylonstation.NativeFieldInfoPtr_SlotsPerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (SlotsPerLevel));
      Pylonstation.NativeFieldInfoPtr_ActiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (ActiveSequenceGuid));
      Pylonstation.NativeFieldInfoPtr_InactiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (InactiveSequenceGuid));
      Pylonstation.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (ActiveSequenceState));
      Pylonstation.NativeFieldInfoPtr_InactiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (InactiveSequenceState));
      Pylonstation.NativeFieldInfoPtr_ClaimGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (ClaimGuid));
      Pylonstation.NativeFieldInfoPtr_LevelUpGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (LevelUpGuid));
      Pylonstation.NativeFieldInfoPtr_DestroyGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (DestroyGuid));
      Pylonstation.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (State));
      Pylonstation.NativeFieldInfoPtr_TombCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (TombCount));
      Pylonstation.NativeFieldInfoPtr_NestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (NestCount));
      Pylonstation.NativeFieldInfoPtr_SafetyBoxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (SafetyBoxCount));
      Pylonstation.NativeFieldInfoPtr_PrisonCellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (PrisonCellCount));
      Pylonstation.NativeFieldInfoPtr_ChangedStateThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, nameof (ChangedStateThisFrame));
      Pylonstation.NativeMethodInfoPtr_get_IsProcessing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, 100665857);
      Pylonstation.NativeMethodInfoPtr_get_IsDecaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, 100665858);
      Pylonstation.NativeMethodInfoPtr_get_IsExposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, 100665859);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pylonstation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
