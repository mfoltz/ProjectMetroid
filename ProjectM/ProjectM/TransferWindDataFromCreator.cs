// Decompiled with JetBrains decompiler
// Type: ProjectM.TransferWindDataFromCreator
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
  public struct TransferWindDataFromCreator
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatorEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinkedBufferIndex;
    [FieldOffset(0)]
    public Entity CreatorEntity;
    [FieldOffset(8)]
    public int LinkedBufferIndex;

    static TransferWindDataFromCreator()
    {
      Il2CppClassPointerStore<TransferWindDataFromCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TransferWindDataFromCreator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransferWindDataFromCreator>.NativeClassPtr);
      TransferWindDataFromCreator.NativeFieldInfoPtr_CreatorEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferWindDataFromCreator>.NativeClassPtr, nameof (CreatorEntity));
      TransferWindDataFromCreator.NativeFieldInfoPtr_LinkedBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferWindDataFromCreator>.NativeClassPtr, nameof (LinkedBufferIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransferWindDataFromCreator>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
