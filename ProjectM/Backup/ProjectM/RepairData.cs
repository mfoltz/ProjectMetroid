// Decompiled with JetBrains decompiler
// Type: ProjectM.RepairData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RepairData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairDuration;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public PrefabGUID Guid;
    [FieldOffset(12)]
    public float RepairDuration;

    static RepairData()
    {
      Il2CppClassPointerStore<RepairData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RepairData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairData>.NativeClassPtr);
      RepairData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairData>.NativeClassPtr, nameof (Entity));
      RepairData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairData>.NativeClassPtr, nameof (Guid));
      RepairData.NativeFieldInfoPtr_RepairDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairData>.NativeClassPtr, nameof (RepairDuration));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
