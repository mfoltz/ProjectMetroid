// Decompiled with JetBrains decompiler
// Type: ProjectM.OnKillListener
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct OnKillListener
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CallerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FunctionHash;
    [FieldOffset(0)]
    public Entity TargetEntity;
    [FieldOffset(8)]
    public Entity CallerEntity;
    [FieldOffset(16)]
    public int FunctionHash;

    static OnKillListener()
    {
      Il2CppClassPointerStore<OnKillListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (OnKillListener));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnKillListener>.NativeClassPtr);
      OnKillListener.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnKillListener>.NativeClassPtr, nameof (TargetEntity));
      OnKillListener.NativeFieldInfoPtr_CallerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnKillListener>.NativeClassPtr, nameof (CallerEntity));
      OnKillListener.NativeFieldInfoPtr_FunctionHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnKillListener>.NativeClassPtr, nameof (FunctionHash));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnKillListener>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
