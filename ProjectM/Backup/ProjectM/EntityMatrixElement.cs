// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityMatrixElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EntityMatrixElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Matrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    [FieldOffset(0)]
    public float4x4 Matrix;
    [FieldOffset(64)]
    public Entity Entity;

    static EntityMatrixElement()
    {
      Il2CppClassPointerStore<EntityMatrixElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EntityMatrixElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityMatrixElement>.NativeClassPtr);
      EntityMatrixElement.NativeFieldInfoPtr_Matrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMatrixElement>.NativeClassPtr, nameof (Matrix));
      EntityMatrixElement.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMatrixElement>.NativeClassPtr, nameof (Entity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityMatrixElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
