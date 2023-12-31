// Decompiled with JetBrains decompiler
// Type: ProjectM.CameraSweepSingleton
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.IO;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CameraSweepSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HasReplayTimeOnStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReplayTimeOnStart;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryWriter_CameraSweepSingleton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_CameraSweepSingleton_BinaryReader_0;
    [FieldOffset(0)]
    public bool HasReplayTimeOnStart;
    [FieldOffset(8)]
    public double ReplayTimeOnStart;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722579, XrefRangeEnd = 722580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Serialize(BinaryWriter writer, CameraSweepSingleton data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CameraSweepSingleton.NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryWriter_CameraSweepSingleton_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe CameraSweepSingleton Deserialize(BinaryReader reader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraSweepSingleton.NativeMethodInfoPtr_Deserialize_Public_Static_CameraSweepSingleton_BinaryReader_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CameraSweepSingleton*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CameraSweepSingleton()
    {
      Il2CppClassPointerStore<CameraSweepSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CameraSweepSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraSweepSingleton>.NativeClassPtr);
      CameraSweepSingleton.NativeFieldInfoPtr_HasReplayTimeOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSweepSingleton>.NativeClassPtr, nameof (HasReplayTimeOnStart));
      CameraSweepSingleton.NativeFieldInfoPtr_ReplayTimeOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSweepSingleton>.NativeClassPtr, nameof (ReplayTimeOnStart));
      CameraSweepSingleton.NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryWriter_CameraSweepSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSweepSingleton>.NativeClassPtr, 100663807);
      CameraSweepSingleton.NativeMethodInfoPtr_Deserialize_Public_Static_CameraSweepSingleton_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSweepSingleton>.NativeClassPtr, 100663808);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraSweepSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
