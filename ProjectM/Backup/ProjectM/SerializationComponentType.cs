// Decompiled with JetBrains decompiler
// Type: ProjectM.SerializationComponentType
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SerializationComponentType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public int ComponentId;
    [FieldOffset(4)]
    public ComponentType ComponentType;
    [FieldOffset(12)]
    public FixedString512 Name;

    static SerializationComponentType()
    {
      Il2CppClassPointerStore<SerializationComponentType>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SerializationComponentType));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationComponentType>.NativeClassPtr);
      SerializationComponentType.NativeFieldInfoPtr_ComponentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationComponentType>.NativeClassPtr, nameof (ComponentId));
      SerializationComponentType.NativeFieldInfoPtr_ComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationComponentType>.NativeClassPtr, nameof (ComponentType));
      SerializationComponentType.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationComponentType>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializationComponentType>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
