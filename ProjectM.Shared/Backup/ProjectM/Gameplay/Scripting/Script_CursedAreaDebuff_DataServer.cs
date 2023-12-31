// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CursedAreaDebuff_DataServer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_CursedAreaDebuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicStacksPerTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeInterval;
    private static readonly System.IntPtr NativeFieldInfoPtr_Timer;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamagePerTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_DecreaseTimeInterval;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurseBlockTimeInterval;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurseBlockDecreaseDynamicStacksPerTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_DecreaseDynamicStacksPerTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisionModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisionReductionPerStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisionStartValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisionMinValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImmunityBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockCurseBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurseBlockStacks;
    [FieldOffset(0)]
    public float DynamicStacks;
    [FieldOffset(4)]
    public float DynamicStacksPerTick;
    [FieldOffset(8)]
    public float TimeInterval;
    [FieldOffset(12)]
    public float Timer;
    [FieldOffset(16)]
    public float DamagePerTick;
    [FieldOffset(20)]
    public float DecreaseTimeInterval;
    [FieldOffset(24)]
    public float CurseBlockTimeInterval;
    [FieldOffset(28)]
    public float CurseBlockDecreaseDynamicStacksPerTick;
    [FieldOffset(32)]
    public float DecreaseDynamicStacksPerTick;
    [FieldOffset(36)]
    public ModificationId VisionModificationId;
    [FieldOffset(40)]
    public float VisionReductionPerStack;
    [FieldOffset(44)]
    public float VisionStartValue;
    [FieldOffset(48)]
    public float VisionMinValue;
    [FieldOffset(52)]
    public PrefabGUID ImmunityBuff;
    [FieldOffset(56)]
    public PrefabGUID BlockCurseBuff;
    [FieldOffset(60)]
    public byte CurseBlockStacks;

    static Script_CursedAreaDebuff_DataServer()
    {
      Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CursedAreaDebuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr);
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_DynamicStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (DynamicStacks));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_DynamicStacksPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (DynamicStacksPerTick));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_TimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (TimeInterval));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (Timer));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_DamagePerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (DamagePerTick));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_DecreaseTimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (DecreaseTimeInterval));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_CurseBlockTimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (CurseBlockTimeInterval));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_CurseBlockDecreaseDynamicStacksPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (CurseBlockDecreaseDynamicStacksPerTick));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_DecreaseDynamicStacksPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (DecreaseDynamicStacksPerTick));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_VisionModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (VisionModificationId));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_VisionReductionPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (VisionReductionPerStack));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_VisionStartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (VisionStartValue));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_VisionMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (VisionMinValue));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_ImmunityBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (ImmunityBuff));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_BlockCurseBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (BlockCurseBuff));
      Script_CursedAreaDebuff_DataServer.NativeFieldInfoPtr_CurseBlockStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, nameof (CurseBlockStacks));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CursedAreaDebuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
