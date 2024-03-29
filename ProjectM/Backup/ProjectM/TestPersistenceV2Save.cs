﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.TestPersistenceV2Save
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
  public struct TestPersistenceV2Save
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveDirectoryPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveFileName;
    [FieldOffset(0)]
    public FixedString512 SaveDirectoryPath;
    [FieldOffset(512)]
    public FixedString512 SaveFileName;

    static TestPersistenceV2Save()
    {
      Il2CppClassPointerStore<TestPersistenceV2Save>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TestPersistenceV2Save));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestPersistenceV2Save>.NativeClassPtr);
      TestPersistenceV2Save.NativeFieldInfoPtr_SaveDirectoryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestPersistenceV2Save>.NativeClassPtr, nameof (SaveDirectoryPath));
      TestPersistenceV2Save.NativeFieldInfoPtr_SaveFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestPersistenceV2Save>.NativeClassPtr, nameof (SaveFileName));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TestPersistenceV2Save>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
