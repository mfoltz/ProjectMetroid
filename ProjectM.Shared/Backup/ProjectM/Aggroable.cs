// Decompiled with JetBrains decompiler
// Type: ProjectM.Aggroable
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Aggroable
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public ModifiableFloat DistanceFactor;
    [FieldOffset(8)]
    public ModifiableFloat AggroFactor;
    [FieldOffset(16)]
    public ModifiableBool Value;

    static Aggroable()
    {
      Il2CppClassPointerStore<Aggroable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Aggroable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Aggroable>.NativeClassPtr);
      Aggroable.NativeFieldInfoPtr_DistanceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aggroable>.NativeClassPtr, nameof (DistanceFactor));
      Aggroable.NativeFieldInfoPtr_AggroFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aggroable>.NativeClassPtr, nameof (AggroFactor));
      Aggroable.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aggroable>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Aggroable>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
