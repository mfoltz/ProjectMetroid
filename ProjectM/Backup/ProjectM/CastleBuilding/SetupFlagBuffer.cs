// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.SetupFlagBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetupFlagBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshDyeBufferIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_UdimIndex;
    [FieldOffset(0)]
    public int MeshDyeBufferIndex;
    [FieldOffset(4)]
    public int UdimIndex;

    static SetupFlagBuffer()
    {
      Il2CppClassPointerStore<SetupFlagBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (SetupFlagBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupFlagBuffer>.NativeClassPtr);
      SetupFlagBuffer.NativeFieldInfoPtr_MeshDyeBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupFlagBuffer>.NativeClassPtr, nameof (MeshDyeBufferIndex));
      SetupFlagBuffer.NativeFieldInfoPtr_UdimIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupFlagBuffer>.NativeClassPtr, nameof (UdimIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupFlagBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
