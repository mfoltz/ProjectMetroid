// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantCoffinstation
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantCoffinstation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InjuryEndTimeTicks;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConvertionProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConvertFromUnit;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConvertToUnit;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedServant;
    private static readonly System.IntPtr NativeFieldInfoPtr_Injury;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedServantState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantEyeColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantProficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantGearLevel;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    [FieldOffset(0)]
    public long InjuryEndTimeTicks;
    [FieldOffset(8)]
    public float BloodQuality;
    [FieldOffset(12)]
    public float ConvertionProgress;
    [FieldOffset(16)]
    public FixedString64 ServantName;
    [FieldOffset(80)]
    public PrefabGUID ConvertFromUnit;
    [FieldOffset(84)]
    public PrefabGUID ConvertToUnit;
    [FieldOffset(88)]
    public NetworkedEntity ConnectedServant;
    [FieldOffset(100)]
    public PrefabGUID Injury;
    [FieldOffset(104)]
    public ServantCoffinState State;
    [FieldOffset(108)]
    public GenericEnemyState ConnectedServantState;
    [FieldOffset(112)]
    public ushort ServantSeed;
    [FieldOffset(114)]
    public byte ServantEyeColorIndex;
    [FieldOffset(116)]
    public float ServantProficiency;
    [FieldOffset(120)]
    public float ServantGearLevel;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1067005, RefRangeEnd = 1067007, XrefRangeStart = 1067000, XrefRangeEnd = 1067005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantCoffinstation.NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantCoffinstation()
    {
      Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantCoffinstation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr);
      ServantCoffinstation.NativeFieldInfoPtr_InjuryEndTimeTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (InjuryEndTimeTicks));
      ServantCoffinstation.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (BloodQuality));
      ServantCoffinstation.NativeFieldInfoPtr_ConvertionProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ConvertionProgress));
      ServantCoffinstation.NativeFieldInfoPtr_ServantName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ServantName));
      ServantCoffinstation.NativeFieldInfoPtr_ConvertFromUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ConvertFromUnit));
      ServantCoffinstation.NativeFieldInfoPtr_ConvertToUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ConvertToUnit));
      ServantCoffinstation.NativeFieldInfoPtr_ConnectedServant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ConnectedServant));
      ServantCoffinstation.NativeFieldInfoPtr_Injury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (Injury));
      ServantCoffinstation.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (State));
      ServantCoffinstation.NativeFieldInfoPtr_ConnectedServantState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ConnectedServantState));
      ServantCoffinstation.NativeFieldInfoPtr_ServantSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ServantSeed));
      ServantCoffinstation.NativeFieldInfoPtr_ServantEyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ServantEyeColorIndex));
      ServantCoffinstation.NativeFieldInfoPtr_ServantProficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ServantProficiency));
      ServantCoffinstation.NativeFieldInfoPtr_ServantGearLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, nameof (ServantGearLevel));
      ServantCoffinstation.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, 100683921);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantCoffinstation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
