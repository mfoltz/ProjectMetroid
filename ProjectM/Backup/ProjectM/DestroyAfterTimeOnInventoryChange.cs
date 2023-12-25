// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyAfterTimeOnInventoryChange
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroyAfterTimeOnInventoryChange
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hash;
    private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_Triggered;
    [FieldOffset(0)]
    public float Duration;
    [FieldOffset(4)]
    public int Hash;
    [FieldOffset(8)]
    public bool Initialized;
    [FieldOffset(9)]
    public bool Triggered;

    static DestroyAfterTimeOnInventoryChange()
    {
      Il2CppClassPointerStore<DestroyAfterTimeOnInventoryChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DestroyAfterTimeOnInventoryChange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyAfterTimeOnInventoryChange>.NativeClassPtr);
      DestroyAfterTimeOnInventoryChange.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterTimeOnInventoryChange>.NativeClassPtr, nameof (Duration));
      DestroyAfterTimeOnInventoryChange.NativeFieldInfoPtr_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterTimeOnInventoryChange>.NativeClassPtr, nameof (Hash));
      DestroyAfterTimeOnInventoryChange.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterTimeOnInventoryChange>.NativeClassPtr, nameof (Initialized));
      DestroyAfterTimeOnInventoryChange.NativeFieldInfoPtr_Triggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterTimeOnInventoryChange>.NativeClassPtr, nameof (Triggered));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyAfterTimeOnInventoryChange>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
