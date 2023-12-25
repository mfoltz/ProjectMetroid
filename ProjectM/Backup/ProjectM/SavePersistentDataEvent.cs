// Decompiled with JetBrains decompiler
// Type: ProjectM.SavePersistentDataEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SavePersistentDataEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Reason;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveFileName;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompressSaveFiles;
    [FieldOffset(0)]
    public SaveReason Reason;
    [FieldOffset(4)]
    public FixedString512 SaveFileName;
    [FieldOffset(516)]
    public bool CompressSaveFiles;

    static SavePersistentDataEvent()
    {
      Il2CppClassPointerStore<SavePersistentDataEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SavePersistentDataEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SavePersistentDataEvent>.NativeClassPtr);
      SavePersistentDataEvent.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePersistentDataEvent>.NativeClassPtr, nameof (Reason));
      SavePersistentDataEvent.NativeFieldInfoPtr_SaveFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePersistentDataEvent>.NativeClassPtr, nameof (SaveFileName));
      SavePersistentDataEvent.NativeFieldInfoPtr_CompressSaveFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavePersistentDataEvent>.NativeClassPtr, nameof (CompressSaveFiles));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SavePersistentDataEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
