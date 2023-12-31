// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ScheduledFunction
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ScheduledFunction
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CallerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FunctionHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationToCall;
    [FieldOffset(0)]
    public Entity CallerEntity;
    [FieldOffset(8)]
    public int FunctionHash;
    [FieldOffset(12)]
    public float DurationToCall;

    static ScheduledFunction()
    {
      Il2CppClassPointerStore<ScheduledFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ScheduledFunction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduledFunction>.NativeClassPtr);
      ScheduledFunction.NativeFieldInfoPtr_CallerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledFunction>.NativeClassPtr, nameof (CallerEntity));
      ScheduledFunction.NativeFieldInfoPtr_FunctionHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledFunction>.NativeClassPtr, nameof (FunctionHash));
      ScheduledFunction.NativeFieldInfoPtr_DurationToCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledFunction>.NativeClassPtr, nameof (DurationToCall));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScheduledFunction>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
