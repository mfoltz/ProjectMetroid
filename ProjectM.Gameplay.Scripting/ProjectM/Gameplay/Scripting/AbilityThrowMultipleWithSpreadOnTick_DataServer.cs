// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.AbilityThrowMultipleWithSpreadOnTick_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityThrowMultipleWithSpreadOnTick_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomHitRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewThrowEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseUnitPositionInsteadOfAimPosition;
    [FieldOffset(0)]
    public float RandomHitRadius;
    [FieldOffset(4)]
    public PrefabGUID NewThrowEntity;
    [FieldOffset(8)]
    public int Count;
    [FieldOffset(12)]
    public bool UseUnitPositionInsteadOfAimPosition;

    static AbilityThrowMultipleWithSpreadOnTick_DataServer()
    {
      Il2CppClassPointerStore<AbilityThrowMultipleWithSpreadOnTick_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (AbilityThrowMultipleWithSpreadOnTick_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityThrowMultipleWithSpreadOnTick_DataServer>.NativeClassPtr);
      AbilityThrowMultipleWithSpreadOnTick_DataServer.NativeFieldInfoPtr_RandomHitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityThrowMultipleWithSpreadOnTick_DataServer>.NativeClassPtr, nameof (RandomHitRadius));
      AbilityThrowMultipleWithSpreadOnTick_DataServer.NativeFieldInfoPtr_NewThrowEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityThrowMultipleWithSpreadOnTick_DataServer>.NativeClassPtr, nameof (NewThrowEntity));
      AbilityThrowMultipleWithSpreadOnTick_DataServer.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityThrowMultipleWithSpreadOnTick_DataServer>.NativeClassPtr, nameof (Count));
      AbilityThrowMultipleWithSpreadOnTick_DataServer.NativeFieldInfoPtr_UseUnitPositionInsteadOfAimPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityThrowMultipleWithSpreadOnTick_DataServer>.NativeClassPtr, nameof (UseUnitPositionInsteadOfAimPosition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityThrowMultipleWithSpreadOnTick_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
