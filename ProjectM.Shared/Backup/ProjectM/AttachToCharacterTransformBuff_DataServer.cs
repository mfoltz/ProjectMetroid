// Decompiled with JetBrains decompiler
// Type: ProjectM.AttachToCharacterTransformBuff_DataServer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AttachToCharacterTransformBuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientPositionOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientRotationOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerPositionOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridBone;
    [FieldOffset(0)]
    public float3 ClientPositionOffset;
    [FieldOffset(12)]
    public float3 ClientRotationOffset;
    [FieldOffset(24)]
    public float3 ServerPositionOffset;
    [FieldOffset(36)]
    public int HybridBone;

    static AttachToCharacterTransformBuff_DataServer()
    {
      Il2CppClassPointerStore<AttachToCharacterTransformBuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AttachToCharacterTransformBuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachToCharacterTransformBuff_DataServer>.NativeClassPtr);
      AttachToCharacterTransformBuff_DataServer.NativeFieldInfoPtr_ClientPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachToCharacterTransformBuff_DataServer>.NativeClassPtr, nameof (ClientPositionOffset));
      AttachToCharacterTransformBuff_DataServer.NativeFieldInfoPtr_ClientRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachToCharacterTransformBuff_DataServer>.NativeClassPtr, nameof (ClientRotationOffset));
      AttachToCharacterTransformBuff_DataServer.NativeFieldInfoPtr_ServerPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachToCharacterTransformBuff_DataServer>.NativeClassPtr, nameof (ServerPositionOffset));
      AttachToCharacterTransformBuff_DataServer.NativeFieldInfoPtr_HybridBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachToCharacterTransformBuff_DataServer>.NativeClassPtr, nameof (HybridBone));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachToCharacterTransformBuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
