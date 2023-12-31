// Decompiled with JetBrains decompiler
// Type: ProjectM.InventoryInstanceElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InventoryInstanceElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Category;
    private static readonly System.IntPtr NativeFieldInfoPtr_Slots;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExternalInventoryEntityPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExternalInventoryEntity;
    [FieldOffset(0)]
    public InventoryInstanceElement.InstanceCategory Category;
    [FieldOffset(4)]
    public int Slots;
    [FieldOffset(8)]
    public PrefabGUID ExternalInventoryEntityPrefabGuid;
    [FieldOffset(12)]
    public NetworkedEntity ExternalInventoryEntity;

    static InventoryInstanceElement()
    {
      Il2CppClassPointerStore<InventoryInstanceElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InventoryInstanceElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryInstanceElement>.NativeClassPtr);
      InventoryInstanceElement.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryInstanceElement>.NativeClassPtr, nameof (Category));
      InventoryInstanceElement.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryInstanceElement>.NativeClassPtr, nameof (Slots));
      InventoryInstanceElement.NativeFieldInfoPtr_ExternalInventoryEntityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryInstanceElement>.NativeClassPtr, nameof (ExternalInventoryEntityPrefabGuid));
      InventoryInstanceElement.NativeFieldInfoPtr_ExternalInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryInstanceElement>.NativeClassPtr, nameof (ExternalInventoryEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryInstanceElement>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum InstanceCategory
    {
      Main,
      Bag,
    }
  }
}
