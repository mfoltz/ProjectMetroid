// Decompiled with JetBrains decompiler
// Type: ProjectM.StartItemBuffer
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
  public struct StartItemBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousEntity;
    [FieldOffset(0)]
    public PrefabGUID Type;
    [FieldOffset(4)]
    public int Stacks;
    [FieldOffset(8)]
    public Entity PreviousEntity;

    static StartItemBuffer()
    {
      Il2CppClassPointerStore<StartItemBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StartItemBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartItemBuffer>.NativeClassPtr);
      StartItemBuffer.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartItemBuffer>.NativeClassPtr, nameof (Type));
      StartItemBuffer.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartItemBuffer>.NativeClassPtr, nameof (Stacks));
      StartItemBuffer.NativeFieldInfoPtr_PreviousEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartItemBuffer>.NativeClassPtr, nameof (PreviousEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartItemBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
