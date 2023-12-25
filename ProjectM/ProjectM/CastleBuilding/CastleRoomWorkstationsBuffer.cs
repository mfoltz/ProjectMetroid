// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleRoomWorkstationsBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleRoomWorkstationsBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorkstationEntity;
    [FieldOffset(0)]
    public Entity WorkstationEntity;

    static CastleRoomWorkstationsBuffer()
    {
      Il2CppClassPointerStore<CastleRoomWorkstationsBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleRoomWorkstationsBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRoomWorkstationsBuffer>.NativeClassPtr);
      CastleRoomWorkstationsBuffer.NativeFieldInfoPtr_WorkstationEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoomWorkstationsBuffer>.NativeClassPtr, nameof (WorkstationEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRoomWorkstationsBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
