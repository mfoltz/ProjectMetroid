// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ProfessorProjectileOnGameplayEvent_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_ProfessorProjectileOnGameplayEvent_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Angle;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewProjectileEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewProjectileEntityAlternate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_TickCount;
    [FieldOffset(0)]
    public float Angle;
    [FieldOffset(4)]
    public float RandomOffset;
    [FieldOffset(8)]
    public float IndividualRandom;
    [FieldOffset(12)]
    public PrefabGUID NewProjectileEntity;
    [FieldOffset(16)]
    public PrefabGUID NewProjectileEntityAlternate;
    [FieldOffset(20)]
    public int Count;
    [FieldOffset(24)]
    public int TickCount;

    static Script_ProfessorProjectileOnGameplayEvent_DataServer()
    {
      Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ProfessorProjectileOnGameplayEvent_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr);
      Script_ProfessorProjectileOnGameplayEvent_DataServer.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr, nameof (Angle));
      Script_ProfessorProjectileOnGameplayEvent_DataServer.NativeFieldInfoPtr_RandomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr, nameof (RandomOffset));
      Script_ProfessorProjectileOnGameplayEvent_DataServer.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr, nameof (IndividualRandom));
      Script_ProfessorProjectileOnGameplayEvent_DataServer.NativeFieldInfoPtr_NewProjectileEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr, nameof (NewProjectileEntity));
      Script_ProfessorProjectileOnGameplayEvent_DataServer.NativeFieldInfoPtr_NewProjectileEntityAlternate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr, nameof (NewProjectileEntityAlternate));
      Script_ProfessorProjectileOnGameplayEvent_DataServer.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr, nameof (Count));
      Script_ProfessorProjectileOnGameplayEvent_DataServer.NativeFieldInfoPtr_TickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr, nameof (TickCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
