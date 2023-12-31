// Decompiled with JetBrains decompiler
// Type: ProjectM.DropTableData
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
  public struct DropTableData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTableLevel;
    [FieldOffset(0)]
    public PrefabGUID Guid;
    [FieldOffset(4)]
    public Entity Entity;
    [FieldOffset(12)]
    public int DropTableLevel;

    static DropTableData()
    {
      Il2CppClassPointerStore<DropTableData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DropTableData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropTableData>.NativeClassPtr);
      DropTableData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableData>.NativeClassPtr, nameof (Guid));
      DropTableData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableData>.NativeClassPtr, nameof (Entity));
      DropTableData.NativeFieldInfoPtr_DropTableLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableData>.NativeClassPtr, nameof (DropTableLevel));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropTableData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
