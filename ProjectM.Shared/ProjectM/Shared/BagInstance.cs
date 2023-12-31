// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.BagInstance
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BagInstance
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryIndex;
    [FieldOffset(0)]
    public NetworkedEntity Entity;
    [FieldOffset(12)]
    public int InventoryIndex;

    static BagInstance()
    {
      Il2CppClassPointerStore<BagInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (BagInstance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BagInstance>.NativeClassPtr);
      BagInstance.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagInstance>.NativeClassPtr, nameof (Entity));
      BagInstance.NativeFieldInfoPtr_InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagInstance>.NativeClassPtr, nameof (InventoryIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BagInstance>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
