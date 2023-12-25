// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollDriver
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
  public struct RagdollDriver
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrivenEntity;
    [FieldOffset(0)]
    public float SpawnTime;
    [FieldOffset(4)]
    public Entity DrivenEntity;

    static RagdollDriver()
    {
      Il2CppClassPointerStore<RagdollDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RagdollDriver));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollDriver>.NativeClassPtr);
      RagdollDriver.NativeFieldInfoPtr_SpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriver>.NativeClassPtr, nameof (SpawnTime));
      RagdollDriver.NativeFieldInfoPtr_DrivenEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriver>.NativeClassPtr, nameof (DrivenEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollDriver>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
