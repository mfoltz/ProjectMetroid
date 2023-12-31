// Decompiled with JetBrains decompiler
// Type: ProjectM.GlobalDeathListener
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
  public struct GlobalDeathListener
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CallerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FunctionHash;
    [FieldOffset(0)]
    public Entity CallerEntity;
    [FieldOffset(8)]
    public int FunctionHash;

    static GlobalDeathListener()
    {
      Il2CppClassPointerStore<GlobalDeathListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GlobalDeathListener));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalDeathListener>.NativeClassPtr);
      GlobalDeathListener.NativeFieldInfoPtr_CallerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDeathListener>.NativeClassPtr, nameof (CallerEntity));
      GlobalDeathListener.NativeFieldInfoPtr_FunctionHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDeathListener>.NativeClassPtr, nameof (FunctionHash));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalDeathListener>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
