// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffModificationFlagData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BuffModificationFlagData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId;
    [FieldOffset(0)]
    public long ModificationTypes;
    [FieldOffset(8)]
    public ModificationId ModificationId;

    static BuffModificationFlagData()
    {
      Il2CppClassPointerStore<BuffModificationFlagData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BuffModificationFlagData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModificationFlagData>.NativeClassPtr);
      BuffModificationFlagData.NativeFieldInfoPtr_ModificationTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModificationFlagData>.NativeClassPtr, nameof (ModificationTypes));
      BuffModificationFlagData.NativeFieldInfoPtr_ModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModificationFlagData>.NativeClassPtr, nameof (ModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffModificationFlagData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
