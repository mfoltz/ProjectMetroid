// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantCoffinEffects
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantCoffinEffects
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnExitOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTravelBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnAnimationGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveConversionGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveConversionState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveServantGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveServantState;
    private static readonly System.IntPtr NativeFieldInfoPtr_WakeUpReadyGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_WakeUpReadyState;
    [FieldOffset(0)]
    public float3 SpawnExitOffset;
    [FieldOffset(12)]
    public PrefabGUID SpawnTravelBuff;
    [FieldOffset(16)]
    public SequenceGUID SpawnAnimationGuid;
    [FieldOffset(20)]
    public SequenceGUID ActiveConversionGuid;
    [FieldOffset(24)]
    public SequenceState ActiveConversionState;
    [FieldOffset(32)]
    public SequenceGUID ActiveServantGuid;
    [FieldOffset(36)]
    public SequenceState ActiveServantState;
    [FieldOffset(44)]
    public SequenceGUID WakeUpReadyGuid;
    [FieldOffset(48)]
    public SequenceState WakeUpReadyState;

    static ServantCoffinEffects()
    {
      Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantCoffinEffects));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr);
      ServantCoffinEffects.NativeFieldInfoPtr_SpawnExitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, nameof (SpawnExitOffset));
      ServantCoffinEffects.NativeFieldInfoPtr_SpawnTravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, nameof (SpawnTravelBuff));
      ServantCoffinEffects.NativeFieldInfoPtr_SpawnAnimationGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, nameof (SpawnAnimationGuid));
      ServantCoffinEffects.NativeFieldInfoPtr_ActiveConversionGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, nameof (ActiveConversionGuid));
      ServantCoffinEffects.NativeFieldInfoPtr_ActiveConversionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, nameof (ActiveConversionState));
      ServantCoffinEffects.NativeFieldInfoPtr_ActiveServantGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, nameof (ActiveServantGuid));
      ServantCoffinEffects.NativeFieldInfoPtr_ActiveServantState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, nameof (ActiveServantState));
      ServantCoffinEffects.NativeFieldInfoPtr_WakeUpReadyGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, nameof (WakeUpReadyGuid));
      ServantCoffinEffects.NativeFieldInfoPtr_WakeUpReadyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, nameof (WakeUpReadyState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantCoffinEffects>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
