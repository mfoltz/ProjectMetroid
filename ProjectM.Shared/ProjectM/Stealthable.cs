// Decompiled with JetBrains decompiler
// Type: ProjectM.Stealthable
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Stealthable
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsStealthed;
    private static readonly System.IntPtr NativeFieldInfoPtr_StealthBushId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModelInvisible;
    [FieldOffset(0)]
    public ModifiableBool IsStealthed;
    [FieldOffset(4)]
    public ModifiableInt StealthBushId;
    [FieldOffset(12)]
    public ModifiableBool ModelInvisible;

    static Stealthable()
    {
      Il2CppClassPointerStore<Stealthable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Stealthable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stealthable>.NativeClassPtr);
      Stealthable.NativeFieldInfoPtr_IsStealthed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stealthable>.NativeClassPtr, nameof (IsStealthed));
      Stealthable.NativeFieldInfoPtr_StealthBushId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stealthable>.NativeClassPtr, nameof (StealthBushId));
      Stealthable.NativeFieldInfoPtr_ModelInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stealthable>.NativeClassPtr, nameof (ModelInvisible));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Stealthable>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
